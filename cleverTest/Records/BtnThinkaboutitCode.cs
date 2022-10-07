/*
 * Created by Ranorex
 * User: giare
 * Date: 7.10.2022
 * Time: 09:19
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
    /// Description of BtnThinkaboutitCode.
    /// </summary>
    [TestModule("90366076-E6F6-4BD0-8C4C-2DE97ED283AF", ModuleType.UserCode, 1)]
    public class BtnThinkaboutitCode : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BtnThinkaboutitCode()
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
             for (int i = 0; i < 10; i++) {
             	appRepo.ApplicationUnderTest.Avatarform1.Thinkaboutitbutton.Click();
            	}
        }
    }
}
