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

namespace cleverTest.Records
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BtnThinkforme recording.
    /// </summary>
    [TestModule("c9b82d92-696b-4e56-9064-581217d00831", ModuleType.Recording, 1)]
    public partial class BtnThinkforme : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::cleverTest.cleverTestRepository repository.
        /// </summary>
        public static global::cleverTest.cleverTestRepository repo = global::cleverTest.cleverTestRepository.Instance;

        static BtnThinkforme instance = new BtnThinkforme();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BtnThinkforme()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BtnThinkforme Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Thinkformebutton' at 62;14.", repo.ApplicationUnderTest.ThinkformebuttonInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Thinkformebutton.Click("62;14");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}