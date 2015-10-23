﻿Imports System.Web.Optimization

Public Module BundleConfig

    Public Sub RegisterBundles(bundles As BundleCollection)

        bundles.Add(New StyleBundle("~/Content/Basic").Include("~/Content/Jack.css",
                                                               "~/Content/bootstrap.min.css",
                                                               "~/Content/bootstrap-theme.min.css",
                                                               "~/Content/toastr.min.css",
                                                               "~/Content/awesomplete.css",
                                                               "~/Content/css/select2.css"))
        'all
        bundles.Add(New ScriptBundle("~/bundles/Basic").Include("~/Scripts/jquery-2.1.4.min.js",
                                                                "~/Scripts/angular.min.js",
                                                                "~/Scripts/toastr.min.js",
                                                                "~/Scripts/bootstrap.min.js",
                                                                "~/Scripts/awesomplete.js",
                                                                "~/Scripts/select2.js"))

        'pages
        bundles.Add(New ScriptBundle("~/bundles/engine").Include("~/engine/mensagens.js", "~/engine/util.js"))
        bundles.Add(New ScriptBundle("~/bundles/familia").Include("~/engine/familia.js", "~/engine/familia.controller.js", "~/engine/familia.presentation.js"))
        bundles.Add(New ScriptBundle("~/bundles/status").Include("~/engine/status.js"))

    End Sub

End Module
