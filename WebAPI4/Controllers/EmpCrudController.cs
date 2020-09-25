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
        CrudEntities CrudEntities = new CrudEntities();
    }
}
