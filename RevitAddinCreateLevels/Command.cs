#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

#endregion

namespace RevitAddinCreateLevels
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;
            View view = doc.ActiveView;

            // FilteredElementCollectorでレベルを全部取得する
            List<Level> levels = new FilteredElementCollector(doc)
                .OfClass(typeof(Level))
                .OfCategory(BuiltInCategory.OST_Levels)
                .Cast<Level>()
                .ToList();
            //レベルを高い順にソート（見た目のため）
            levels.Sort((a, b) => b.Elevation.CompareTo(a.Elevation));
            //フォーム作成
            Form1 form1 = new Form1();
            //既設レベルから LevelClassクラスのインスタンスを作ってデータバインディングのexsistLevelsに追加
            List<string> levelStrings = new List<string>();
            foreach (var level in levels)
            {
                //小数点以下0桁で四捨五入表示
                double levelHeightDigit = Math.Round(Conv2(level.Elevation), 0, MidpointRounding.AwayFromZero);
                LevelClass levelClass = new LevelClass() { LevelName = $"{level.Name}", LevelHeight = levelHeightDigit };
                form1.exsistLevels.Add(levelClass);
            }
            //フォーム表示
            form1.ShowDialog();
            //OKボタンが押された場合
            if (form1.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                using (Transaction tx = new Transaction(doc))
                {
                    tx.Start("Create Levels");
                    //データバインディングのnewLevelsからLevelClassクラスのインスタンスを作って新規レベルを作成
                    foreach (LevelClass lebelClass in form1.newLevels)
                    {
                        //新規レベルの名前
                        string levelName = lebelClass.LevelName;
                        //新規レベルの高さ
                        double levelHeight = Conv(lebelClass.LevelHeight);
                        //レベルを作成する
                        Level newLevelElement = Level.Create(doc, levelHeight);
                        newLevelElement.Name = levelName;
                    }
                    tx.Commit();
                }
            }
            else if (form1.DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                //キャンセルボタンが押された場合
                return Result.Cancelled;
            }
            return Result.Succeeded;
        }
        //ミリメートル単位を内部単位に変換
        private static double Conv(double mm)
        {
            return UnitUtils.ConvertToInternalUnits(mm, UnitTypeId.Millimeters);
        }
        //内部単位をミリメートル単位に変換
        private static double Conv2(double mm)
        {
            return UnitUtils.ConvertFromInternalUnits(mm, UnitTypeId.Millimeters);
        }
    }
}
