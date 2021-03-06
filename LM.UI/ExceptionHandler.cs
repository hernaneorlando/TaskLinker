﻿using LM.UI.View;
using System;
using System.Threading;

namespace LM.UI
{
    public class ExceptionHandler
    {
        private readonly IExceptionView _exceptionView;

        public ExceptionHandler(IExceptionView exceptionView)
        {
            _exceptionView = exceptionView;
        }

        internal void ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            _exceptionView.ShowException(e.Exception);
        }

        internal void UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            _exceptionView.ShowException(e.ExceptionObject as Exception);
        }
    }
}
