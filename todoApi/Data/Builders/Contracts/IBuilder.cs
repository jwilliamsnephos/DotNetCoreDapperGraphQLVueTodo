using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace todoApi.Data.Builders
{
    public interface IBuilder
    {
        Bindable WhereFromJson(String json);
        Bindable Where(JObject json);
    }
}