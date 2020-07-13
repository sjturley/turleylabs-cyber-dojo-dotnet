using System;
using ApprovalTests.Core; 

public class CyberDojoNamer : IApprovalNamer
{
    public string SourcePath 
    {
        get 
        {
            return "/sandbox/";
        }
    }

    public string Name 
    {
        get
        {
            return "VideoStoreTest.ApproveCustomerStatement";
        }
    }
}
    
