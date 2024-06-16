using UiPath.CodedWorkflows;
using System;

namespace RayaRPARepository
{
    public class ExcelFactory
    {
        public ExcelFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class O365MailFactory
    {
        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Dispatcher_ahmed_shawkey_rayacorp_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection My_Workspace_mohamed_gaber_rayacorp_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection Mohamed_Abdelnaby_mohamed_gaber_rayacorp_com { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection My_Workspace_Microsoft_Outlook_365 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection SedcoAPI_Microsoft_Outlook_365 { get; set; }

        public UiPath.MicrosoftOffice365.Activities.Api.MailConnection My_Workspace_mohamed_gaber_rayacorp_com__2 { get; set; }

        public O365MailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            Dispatcher_ahmed_shawkey_rayacorp_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("657ea825-1b32-40b3-983a-e41300a4282a", resolver);
            My_Workspace_mohamed_gaber_rayacorp_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("7707998c-23d8-4b8d-a352-8db7a4a4d37a", resolver);
            Mohamed_Abdelnaby_mohamed_gaber_rayacorp_com = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("88284026-ebed-4a56-907d-f14810e7ae28", resolver);
            My_Workspace_Microsoft_Outlook_365 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("5aeaddf3-f6f1-4490-997a-131e91c52bb9", resolver);
            SedcoAPI_Microsoft_Outlook_365 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("908f9583-e1b2-4b99-af1b-ebc800519ace", resolver);
            My_Workspace_mohamed_gaber_rayacorp_com__2 = new UiPath.MicrosoftOffice365.Activities.Api.MailConnection("c4be02ee-1268-40f7-836c-e0030d552951", resolver);
        }
    }

    public class OneDriveFactory
    {
        public OneDriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }
}