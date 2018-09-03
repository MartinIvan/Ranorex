/*
 * Created by Ranorex
 * User: Ivan
 * Date: 24.08.2018
 * Time: 9:46
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace eadcs
{
    /// <summary>
    /// Description of UserTestCode1.
    /// </summary>
    [TestModule("1B973B8B-6C5D-4372-8AA2-17FF08F99CF3", ModuleType.UserCode, 0)]
    public class UserTestCode1 : ITestModule
    {
    	
    	public readonly String PathToBtnOkOpenGeoTech ="?/?/element[@instance='0']/button[@text='О&К']";

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserTestCode1()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
       
        void OpenGeoTech(){
        	
            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\Mineframe 7.0\\bin\\GeoTech.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files (x86)\\Mineframe 7.0\\bin\\GeoTech.exe", "", "C:\\Program Files (x86)\\Mineframe 7.0\\bin", false);
            Delay.Milliseconds(0);
            
            var repo = eadcsRepository.Instance;
            var buttonОК = repo.Информация.ButtonОК;
            buttonОК.Click();

        }
        
        void SetCharachteristicsOfNewProject(){
        	var repo = eadcsRepository.Instance;
        	var xminEdit = repo.GEOTECH3D2.TabbedNotebook1.XminEdit;
        	xminEdit.Click();
        	Keyboard.Press("-1500");
        	var xmaxEdit = repo.GEOTECH3D2.TabbedNotebook1.XmaxEdit;
        	xmaxEdit.Click();
        	Keyboard.Press("2500");
        	var yminEdit = repo.GEOTECH3D2.TabbedNotebook1.YminEdit;
        	yminEdit.Click();
        	Keyboard.Press("1500");
        	var ymaxEdit = repo.GEOTECH3D2.TabbedNotebook1.YmaxEdit;
        	ymaxEdit.Click();
        	Keyboard.Press("1000");

        	var выполнить = repo.GEOTECH3D2.Выполнить;
        	выполнить.Click();


        	
        }
        void CreateNewProject(){
        	
        	var repo = eadcsRepository.Instance;
        	var символ = repo.GeoTech3D7ГеологияМаркшейде.Символ;
        	символ.Click();
        	var создатьCtrlPlusN = repo.GeoTech.СоздатьCtrlPlusN;
        	создатьCtrlPlusN.Click();
        	var sbtCreateProject = repo.GeoTech3D.SbtCreateProject;
        	sbtCreateProject.Click();
        	var edProjectName = repo.GeoTech3D1.EdProjectName;
        	edProjectName.Click();
        	
        	Keyboard.Press(Guid.NewGuid().ToString("N").Substring(0,8));
        	var применить = repo.GeoTech3D1.Применить;
        	применить.Click();
        	SetCharachteristicsOfNewProject();
 
        }
        void CreateNewObject(){
        	var repo = eadcsRepository.Instance;
        	var someElement = repo.GeoTech3D7ГеологияМаркшейде.SomeElement;
        	someElement.Click();
//        	var objInsp = repo.GeoTech3D7ГеологияМаркшейде.ObjInsp;
//        	objInsp.DoubleClick();
//			программа не находит элементы плоскости
        	Keyboard.Press("ploskost");
        	var propOkBtn = repo.GeoTech3D7ГеологияМаркшейде.PropOkBtn;
        	propOkBtn.Click();


        }
        void CreateNewSechenie(){
        	var repo = eadcsRepository.Instance;
        	var someElement1 = repo.GeoTech3D7ГеологияМаркшейде.SomeElement1;
        	someElement1.Click();
        	
        }
        void ImportFromFile(){
        	String pathToFile="D:\\TestingMineFrame\\База объектов ОГР 7 и ПГР 7\\Горный план.dxf";
        	var repo = eadcsRepository.Instance;
        	var действия = repo.GeoTech3D7ГеологияМаркшейде.Действия;
        	действия.Click();
        	var импортИзФайла = repo.GeoTech.ИмпортИзФайла;
        	импортИзФайла.Click();
        	

        	var comboBox1148 = repo.Открытие.ComboBox1148;
        	comboBox1148.Click();
        	Keyboard.Press(pathToFile);
        	var buttonОткрыть = repo.Открытие.ButtonОткрыть;
        	buttonОткрыть.Click();
        	var геодезические = repo.GEOTECH3D3.Геодезические;
        	геодезические.Click();
        	var импорт = repo.GEOTECH3D3.Импорт;
        	импорт.Click();
        	var продолжить = repo.GEOTECH3D4.Продолжить;
        	продолжить.Click();
        }

        
        
        
        
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 100;
            Keyboard.DefaultKeyPressTime = 50;
            Delay.SpeedFactor = 1.0;
            
            // Here is start of test
            
            OpenGeoTech();
            CreateNewProject();
            CreateNewObject();
            CreateNewSechenie();
            ImportFromFile();
            Thread.Sleep(10000);
            
            
            
            
            
            
            
        }
    }

    }

