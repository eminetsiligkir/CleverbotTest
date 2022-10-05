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

namespace cleverTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ChatWord2 recording.
    /// </summary>
    [TestModule("3dfc50b8-ec24-4c94-8334-1a5c055e2f2d", ModuleType.Recording, 1)]
    public partial class ChatWord2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the cleverTestRepository repository.
        /// </summary>
        public static cleverTestRepository repo = cleverTestRepository.Instance;

        static ChatWord2 instance = new ChatWord2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ChatWord2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ChatWord2 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Stimulus' at 33;20.", repo.ApplicationUnderTest.StimulusInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Stimulus.Click("33;20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'action{Return}' with focus on 'ApplicationUnderTest.Stimulus'.", repo.ApplicationUnderTest.StimulusInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Stimulus.PressKeys("action{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}