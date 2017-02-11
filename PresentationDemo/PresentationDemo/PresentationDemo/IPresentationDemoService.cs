using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PresentationDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPresentationDemoService" in both code and config file together.
    [ServiceContract]
    public interface IPresentationDemoService
    {
        [OperationContract]
        string GetTeacherName();

        [OperationContract]
        bool PostComment(string comment);

        [OperationContract]
        string[] GetComments();
    }
}
