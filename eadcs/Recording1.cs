﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace eadcs
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("d7528443-c217-49d9-b129-d08404f9f21d", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the eadcsRepository repository.
        /// </summary>
        public static eadcsRepository repo = eadcsRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 0;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 0.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\Mineframe 7.0\\bin\\GeoTech.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files (x86)\\Mineframe 7.0\\bin\\GeoTech.exe", "", "C:\\Program Files (x86)\\Mineframe 7.0\\bin", false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Информация.ButtonОК' at 65;11.", repo.Информация.ButtonОКInfo, new RecordItemIndex(1));
            repo.Информация.ButtonОК.Click("65;11");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.Символ' at 39;13.", repo.GeoTech3D7ГеологияМаркшейде.СимволInfo, new RecordItemIndex(2));
            repo.GeoTech3D7ГеологияМаркшейде.Символ.Click("39;13");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech.СоздатьCtrlPlusN' at 54;12.", repo.GeoTech.СоздатьCtrlPlusNInfo, new RecordItemIndex(3));
            repo.GeoTech.СоздатьCtrlPlusN.Click("54;12");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'GeoTech3D.SbtCreateProject' at 11;14.", repo.GeoTech3D.SbtCreateProjectInfo, new RecordItemIndex(4));
            repo.GeoTech3D.SbtCreateProject.DoubleClick("11;14");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D1.EdProjectName' at 35;6.", repo.GeoTech3D1.EdProjectNameInfo, new RecordItemIndex(5));
            repo.GeoTech3D1.EdProjectName.Click("35;6");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Пример' with focus on 'GeoTech3D1.EdProjectName'.", repo.GeoTech3D1.EdProjectNameInfo, new RecordItemIndex(6));
            repo.GeoTech3D1.EdProjectName.PressKeys("Пример");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}{Back}{Back}{Back}{Back}{Back}{Back}{LShiftKey down}{LMenu down}{LShiftKey up}{LMenu up}Пример' with focus on 'GeoTech3D1.EdProjectName'.", repo.GeoTech3D1.EdProjectNameInfo, new RecordItemIndex(7));
            repo.GeoTech3D1.EdProjectName.PressKeys("{Back}{Back}{Back}{Back}{Back}{Back}{Back}{LShiftKey down}{LMenu down}{LShiftKey up}{LMenu up}Пример");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'GEOTECH3D2.TabbedNotebook1.XminEdit' at 28;2.", repo.GEOTECH3D2.TabbedNotebook1.XminEditInfo, new RecordItemIndex(8));
            repo.GEOTECH3D2.TabbedNotebook1.XminEdit.MoveTo("28;2");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Subtract}{NumPad1}{NumPad5}{NumPad0}{NumPad0}' with focus on 'GEOTECH3D2.TabbedNotebook1.XminEdit'.", repo.GEOTECH3D2.TabbedNotebook1.XminEditInfo, new RecordItemIndex(9));
            repo.GEOTECH3D2.TabbedNotebook1.XminEdit.PressKeys("{Subtract}{NumPad1}{NumPad5}{NumPad0}{NumPad0}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.XmaxEdit' at 48;11.", repo.GEOTECH3D2.TabbedNotebook1.XmaxEditInfo, new RecordItemIndex(10));
            repo.GEOTECH3D2.TabbedNotebook1.XmaxEdit.Click("48;11");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'GEOTECH3D2.TabbedNotebook1.XmaxEdit' at 56;3.", repo.GEOTECH3D2.TabbedNotebook1.XmaxEditInfo, new RecordItemIndex(11));
            repo.GEOTECH3D2.TabbedNotebook1.XmaxEdit.MoveTo("56;3");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'GeoTech3D7ГеологияМаркшейде.РабочееПространство' at 471;513.", repo.GeoTech3D7ГеологияМаркшейде.РабочееПространствоInfo, new RecordItemIndex(12));
            repo.GeoTech3D7ГеологияМаркшейде.РабочееПространство.MoveTo("471;513");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'GEOTECH3D2.TabbedNotebook1.XmaxEdit' at 40;10.", repo.GEOTECH3D2.TabbedNotebook1.XmaxEditInfo, new RecordItemIndex(13));
            repo.GEOTECH3D2.TabbedNotebook1.XmaxEdit.MoveTo("40;10");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'GEOTECH3D2.TabbedNotebook1.XmaxEdit' at 48;2.", repo.GEOTECH3D2.TabbedNotebook1.XmaxEditInfo, new RecordItemIndex(14));
            repo.GEOTECH3D2.TabbedNotebook1.XmaxEdit.MoveTo("48;2");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'GEOTECH3D2.TabbedNotebook1.ContainerPnl' at 143;221.", repo.GEOTECH3D2.TabbedNotebook1.ContainerPnlInfo, new RecordItemIndex(15));
            repo.GEOTECH3D2.TabbedNotebook1.ContainerPnl.MoveTo("143;221");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad2}{NumPad5}{NumPad0}{NumPad0}' with focus on 'GEOTECH3D2.TabbedNotebook1.XmaxEdit'.", repo.GEOTECH3D2.TabbedNotebook1.XmaxEditInfo, new RecordItemIndex(16));
            repo.GEOTECH3D2.TabbedNotebook1.XmaxEdit.PressKeys("{NumPad2}{NumPad5}{NumPad0}{NumPad0}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'GEOTECH3D2.TabbedNotebook1.YminEdit' at 27;12.", repo.GEOTECH3D2.TabbedNotebook1.YminEditInfo, new RecordItemIndex(17));
            repo.GEOTECH3D2.TabbedNotebook1.YminEdit.MoveTo("27;12");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'GEOTECH3D2.TabbedNotebook1.YminEdit' at 27;12.", repo.GEOTECH3D2.TabbedNotebook1.YminEditInfo, new RecordItemIndex(18));
            repo.GEOTECH3D2.TabbedNotebook1.YminEdit.MoveTo("27;12");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad1}{NumPad5}' with focus on 'GEOTECH3D2.TabbedNotebook1.YminEdit'.", repo.GEOTECH3D2.TabbedNotebook1.YminEditInfo, new RecordItemIndex(19));
            repo.GEOTECH3D2.TabbedNotebook1.YminEdit.PressKeys("{NumPad1}{NumPad5}");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad0}{NumPad0}' with focus on 'GEOTECH3D2.TabbedNotebook1.YminEdit'.", repo.GEOTECH3D2.TabbedNotebook1.YminEditInfo, new RecordItemIndex(20));
            repo.GEOTECH3D2.TabbedNotebook1.YminEdit.PressKeys("{NumPad0}{NumPad0}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.YmaxEdit' at 44;9.", repo.GEOTECH3D2.TabbedNotebook1.YmaxEditInfo, new RecordItemIndex(21));
            repo.GEOTECH3D2.TabbedNotebook1.YmaxEdit.Click("44;9");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.YminEdit' at 5;7.", repo.GEOTECH3D2.TabbedNotebook1.YminEditInfo, new RecordItemIndex(22));
            repo.GEOTECH3D2.TabbedNotebook1.YminEdit.Click("5;7");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.YminEdit' at 5;7.", repo.GEOTECH3D2.TabbedNotebook1.YminEditInfo, new RecordItemIndex(23));
            repo.GEOTECH3D2.TabbedNotebook1.YminEdit.Click("5;7");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Subtract}' with focus on 'GEOTECH3D2.TabbedNotebook1.YminEdit'.", repo.GEOTECH3D2.TabbedNotebook1.YminEditInfo, new RecordItemIndex(24));
            repo.GEOTECH3D2.TabbedNotebook1.YminEdit.PressKeys("{Subtract}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.TabbedNotebook1.YmaxEdit' at 36;9.", repo.GEOTECH3D2.TabbedNotebook1.YmaxEditInfo, new RecordItemIndex(25));
            repo.GEOTECH3D2.TabbedNotebook1.YmaxEdit.Click("36;9");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad2}{NumPad5}{NumPad0}{NumPad0}' with focus on 'GEOTECH3D2.TabbedNotebook1.YmaxEdit'.", repo.GEOTECH3D2.TabbedNotebook1.YmaxEditInfo, new RecordItemIndex(26));
            repo.GEOTECH3D2.TabbedNotebook1.YmaxEdit.PressKeys("{NumPad2}{NumPad5}{NumPad0}{NumPad0}");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D2.Выполнить' at 36;12.", repo.GEOTECH3D2.ВыполнитьInfo, new RecordItemIndex(27));
            repo.GEOTECH3D2.Выполнить.Click("36;12");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.SomeElement' at 14;9.", repo.GeoTech3D7ГеологияМаркшейде.SomeElementInfo, new RecordItemIndex(28));
            repo.GeoTech3D7ГеологияМаркшейде.SomeElement.Click("14;9");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'GeoTech3D7ГеологияМаркшейде.ObjInsp' at 190;12.", repo.GeoTech3D7ГеологияМаркшейде.ObjInspInfo, new RecordItemIndex(29));
            repo.GeoTech3D7ГеологияМаркшейде.ObjInsp.MoveTo("190;12");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'GeoTech3D7ГеологияМаркшейде.ObjInsp' at 190;12.", repo.GeoTech3D7ГеологияМаркшейде.ObjInspInfo, new RecordItemIndex(30));
            repo.GeoTech3D7ГеологияМаркшейде.ObjInsp.MoveTo("190;12");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'гор '.", new RecordItemIndex(31));
            Keyboard.Press("гор ");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'план'.", new RecordItemIndex(32));
            Keyboard.Press("план");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.PropOkBtn' at 28;10.", repo.GeoTech3D7ГеологияМаркшейде.PropOkBtnInfo, new RecordItemIndex(33));
            repo.GeoTech3D7ГеологияМаркшейде.PropOkBtn.Click("28;10");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.SomeElement1' at 7;12.", repo.GeoTech3D7ГеологияМаркшейде.SomeElement1Info, new RecordItemIndex(34));
            repo.GeoTech3D7ГеологияМаркшейде.SomeElement1.Click("7;12");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.Form65280' at 799;408.", repo.GeoTech3D7ГеологияМаркшейде.Form65280Info, new RecordItemIndex(35));
            repo.GeoTech3D7ГеологияМаркшейде.Form65280.Click("799;408");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech3D7ГеологияМаркшейде.Действия' at 40;10.", repo.GeoTech3D7ГеологияМаркшейде.ДействияInfo, new RecordItemIndex(36));
            repo.GeoTech3D7ГеологияМаркшейде.Действия.Click("40;10");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GeoTech.ИмпортИзФайла' at 78;2.", repo.GeoTech.ИмпортИзФайлаInfo, new RecordItemIndex(37));
            repo.GeoTech.ИмпортИзФайла.Click("78;2");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.ShellView.SystemItemNameDisplay' at 63;14.", repo.Открытие.ShellView.SystemItemNameDisplayInfo, new RecordItemIndex(38));
            repo.Открытие.ShellView.SystemItemNameDisplay.Click("63;14");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Открытие.ShellView.SystemItemNameDisplay' at 63;14.", repo.Открытие.ShellView.SystemItemNameDisplayInfo, new RecordItemIndex(39));
            repo.Открытие.ShellView.SystemItemNameDisplay.DoubleClick("63;14");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'Открытие.ShellView.ПросмотрЭлементов' at 109;99.", repo.Открытие.ShellView.ПросмотрЭлементовInfo, new RecordItemIndex(40));
            repo.Открытие.ShellView.ПросмотрЭлементов.MoveTo("109;99");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'Открытие.ShellView.ПросмотрЭлементов' at 109;150.", repo.Открытие.ShellView.ПросмотрЭлементовInfo, new RecordItemIndex(41));
            repo.Открытие.ShellView.ПросмотрЭлементов.MoveTo("109;150");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'Открытие.ShellView.ПросмотрЭлементов' at 68;292.", repo.Открытие.ShellView.ПросмотрЭлементовInfo, new RecordItemIndex(42));
            repo.Открытие.ShellView.ПросмотрЭлементов.MoveTo("68;292");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'Открытие.ShellView.ПросмотрЭлементов' at 74;274.", repo.Открытие.ShellView.ПросмотрЭлементовInfo, new RecordItemIndex(43));
            repo.Открытие.ShellView.ПросмотрЭлементов.MoveTo("74;274");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Открытие.ShellView.UIImage' at 7;17.", repo.Открытие.ShellView.UIImageInfo, new RecordItemIndex(44));
            repo.Открытие.ShellView.UIImage.DoubleClick("7;17");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.Tree1001.ЭтотКомпьютер' at 41;14.", repo.Открытие.Tree1001.ЭтотКомпьютерInfo, new RecordItemIndex(45));
            repo.Открытие.Tree1001.ЭтотКомпьютер.Click("41;14");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Открытие.Tree1001.ЭтотКомпьютер' at 41;14.", repo.Открытие.Tree1001.ЭтотКомпьютерInfo, new RecordItemIndex(46));
            repo.Открытие.Tree1001.ЭтотКомпьютер.DoubleClick("41;14");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(47));
            Mouse.ScrollWheel(-720);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Открытие.Tree1001.ЛокальныйДискD' at 51;15.", repo.Открытие.Tree1001.ЛокальныйДискDInfo, new RecordItemIndex(48));
            repo.Открытие.Tree1001.ЛокальныйДискD.DoubleClick("51;15");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.Tree1001.Tree100' at 27;259.", repo.Открытие.Tree1001.Tree100Info, new RecordItemIndex(49));
            repo.Открытие.Tree1001.Tree100.Click("27;259");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(50));
            Mouse.ScrollWheel(-240);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.Tree1001.Tree100' at 28;227.", repo.Открытие.Tree1001.Tree100Info, new RecordItemIndex(51));
            repo.Открытие.Tree1001.Tree100.Click("28;227");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.Tree1001.Tree100' at 46;227.", repo.Открытие.Tree1001.Tree100Info, new RecordItemIndex(52));
            repo.Открытие.Tree1001.Tree100.Click("46;227");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.Tree1001.Tree100' at 72;251.", repo.Открытие.Tree1001.Tree100Info, new RecordItemIndex(53));
            repo.Открытие.Tree1001.Tree100.Click("72;251");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.SomeButton' at 8;12.", repo.Открытие.SomeButtonInfo, new RecordItemIndex(54));
            repo.Открытие.SomeButton.Click("8;12");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'List1000.ФайлыAutoCAD2004DXFAsteriskDxf' at 209;17.", repo.List1000.ФайлыAutoCAD2004DXFAsteriskDxfInfo, new RecordItemIndex(55));
            repo.List1000.ФайлыAutoCAD2004DXFAsteriskDxf.Click("209;17");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Открытие.БазаОбъектовГеология' at 8;15.", repo.Открытие.БазаОбъектовГеологияInfo, new RecordItemIndex(56));
            repo.Открытие.БазаОбъектовГеология.DoubleClick("8;15");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.БазаОбъектовГеология' at 8;15.", repo.Открытие.БазаОбъектовГеологияInfo, new RecordItemIndex(57));
            repo.Открытие.БазаОбъектовГеология.Click("8;15");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Открытие.Tree1001.Tree100' at 83;257.", repo.Открытие.Tree1001.Tree100Info, new RecordItemIndex(58));
            repo.Открытие.Tree1001.Tree100.DoubleClick("83;257");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.SomeButton1' at 8;6.", repo.Открытие.SomeButton1Info, new RecordItemIndex(59));
            repo.Открытие.SomeButton1.Click("8;6");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Открытие.Tree1001.БазаОбъектовОГР7ИПГР7' at 33;19.", repo.Открытие.Tree1001.БазаОбъектовОГР7ИПГР7Info, new RecordItemIndex(60));
            repo.Открытие.Tree1001.БазаОбъектовОГР7ИПГР7.DoubleClick("33;19");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.ShellView.SystemItemNameDisplay' at 98;9.", repo.Открытие.ShellView.SystemItemNameDisplayInfo, new RecordItemIndex(61));
            repo.Открытие.ShellView.SystemItemNameDisplay.Click("98;9");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Открытие.ButtonОткрыть' at 75;13.", repo.Открытие.ButtonОткрытьInfo, new RecordItemIndex(62));
            repo.Открытие.ButtonОткрыть.Click("75;13");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GEOTECH3D3.Геодезические' at 13;8.", repo.GEOTECH3D3.ГеодезическиеInfo, new RecordItemIndex(63));
            repo.GEOTECH3D3.Геодезические.Click("13;8");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'GEOTECH3D3.Импорт' at 31;18.", repo.GEOTECH3D3.ИмпортInfo, new RecordItemIndex(64));
            repo.GEOTECH3D3.Импорт.MoveTo("31;18");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.GeoTech3D' at 34;24.", repo.Explorer.GeoTech3DInfo, new RecordItemIndex(65));
            repo.Explorer.GeoTech3D.Click("34;24");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Информация.ButtonОК' at 59;9.", repo.Информация.ButtonОКInfo, new RecordItemIndex(66));
            repo.Информация.ButtonОК.Click("59;9");
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Escape}{Escape}'.", new RecordItemIndex(67));
            Keyboard.Press("{Escape}{Escape}");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
