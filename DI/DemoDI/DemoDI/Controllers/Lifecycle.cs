﻿using DemoDI.Cases;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DemoDI.Controllers
{
    public class LifecycleController : Controller
    {
        public OperationService OperationService { get; }
        public OperationService OperationService2 { get; }

        public LifecycleController(OperationService operationService, OperationService operationService2)
        {
            OperationService = operationService;
            OperationService2 = operationService2;
        }

        public string Index()
        {
            return
                "First instance: " + Environment.NewLine +
                OperationService.Transient.OperationId + Environment.NewLine +
                OperationService.Scoped.OperationId + Environment.NewLine +
                OperationService.Singleton.OperationId + Environment.NewLine +
                OperationService.SingletonInstance.OperationId + Environment.NewLine +

                Environment.NewLine +
                Environment.NewLine +

                "Second instance: " + Environment.NewLine +
                OperationService2.Transient.OperationId + Environment.NewLine +
                OperationService2.Scoped.OperationId + Environment.NewLine +
                OperationService2.Singleton.OperationId + Environment.NewLine +
                OperationService2.SingletonInstance.OperationId + Environment.NewLine;
        }
    }
}
