﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Serenity.CodeGenerator.Views
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class EntityEndpoint : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden
 public dynamic Model { get; set; } 
        public override void Execute()
        {


WriteLiteral(Environment.NewLine);



                                                   var dotModule = Model.Module == null ? "" : ("." + Model.Module); var modulePrefix = (Model.Module == null ? "" : (Model.Module + "/"));


WriteLiteral("namespace ");


      Write(Model.RootNamespace);


                            Write(dotModule);

WriteLiteral(".Endpoints" + Environment.NewLine + "{" + Environment.NewLine + "    using Serenity;" + Environment.NewLine + "    using Serenity.Data;" + Environment.NewLine + "    using Serenity." +
"Services;" + Environment.NewLine + "    using System.Data;" + Environment.NewLine + "    using Microsoft.AspNetCore.Mvc;" + Environment.NewLine + "    using MyReposi" +
"tory = Repositories.");


                                  Write(Model.ClassName);

WriteLiteral("Repository;" + Environment.NewLine + "    using MyRow = Entities.");


                       Write(Model.RowClassName);

WriteLiteral(";" + Environment.NewLine + Environment.NewLine + "    [Route(\"Services/");


                       Write(modulePrefix);


                                      Write(Model.ClassName);

WriteLiteral("/[action]\")]" + Environment.NewLine + "    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeo" +
"f(MyRow))]" + Environment.NewLine + "    public class ");


             Write(Model.ClassName);

WriteLiteral(@"Controller : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }
    }
}
");


        }
    }
}
#pragma warning restore 1591