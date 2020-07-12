using CreatingDynamicJson.UI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatingDynamicJson.UI.Helper
{
    public static class JsonHelper
    {
        public static string CreateDynamicJson(this Author model)
        {
            var authorObject = new JObject();
            authorObject.Add("@Author_Id", model.Id);
            authorObject.Add("Name", model.Name);
            authorObject.Add("Citizen", model.Citizen);

            dynamic dynamicAuthorObject = authorObject;
            dynamicAuthorObject.novelList = new JArray() as dynamic;
            
            foreach (var novel in model.Novels)
            {
                var listElement = InsertItemToJArray(novel);
                dynamicAuthorObject.novelList.Add(listElement);
            }
           
            return JsonConvert.SerializeObject(authorObject);
        }

        private static JObject InsertItemToJArray(Novel novel)
        {
            var listElement = new JObject();
            
            listElement.Add("@Novel_Id", novel.Id);
            listElement.Add("Name", novel.Name);
            listElement.Add("Number_Of_Page", novel.NumberOfPage);

            return listElement;
        }
    }
}
