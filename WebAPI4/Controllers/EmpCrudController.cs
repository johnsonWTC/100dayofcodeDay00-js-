using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI4.Models;

namespace WebAPI4.Controllers
{
    public class EmpCrudController : ApiController
    {
     public IHttpActionResult getEmp()
        {

            CrudEntities crudEntities = new CrudEntities();
            var employees = crudEntities.Newempregs.ToList();
            return Ok(employees); 

        }
        
    }
}
