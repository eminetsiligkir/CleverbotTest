/*
 * Created by Ranorex
 * User: giare
 * Date: 6.10.2022
 * Time: 17:09
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

namespace cleverTest.Records
{
    /// <summary>
    /// Description of BtnThinkformeCode.
    /// </summary>
    [TestModule("CA622D00-12E2-48C4-9B9A-1D3B25691D4D", ModuleType.UserCode, 1)]
    public class BtnThinkformeCode : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BtnThinkformeCode()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            cleverTestRepository appRepo = new cleverTestRepository();
            
            //appRepo.ApplicationUnderTest.Thinkformebutton.Click();
            //appRepo.ApplicationUnderTest.ThinkformebuttonInfo.Exists(true);
            
            if (appRepo.ApplicationUnderTest.ThinkformebuttonInfo.Exists()) {
            	for (int i = 0; i < 10; i++) {
            	  appRepo.ApplicationUnderTest.Thinkformebutton.Click();
            	}
            }
        }
        
    }
}
