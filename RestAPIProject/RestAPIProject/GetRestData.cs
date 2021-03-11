using RestSharp;

namespace RestAPIProject
{
    public class GetRestData

    {
        public void getApiData(string Path, string FileName)
        {
            var client = new RestClient("https://eservices.mas.gov.sg/api/action/datastore/search.json?resource_id=7e181136-d81a-48a8-9350-3f09265db3c7&limit=5");
            var req = new RestRequest();
            var response = client.Execute(req);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {

                string rawResponse = response.Content;

                Aspose.Cells.Workbook workbook = new Aspose.Cells.Workbook();
                Aspose.Cells.Cells cells = workbook.Worksheets[0].Cells;

                Aspose.Cells.Utility.JsonLayoutOptions importOptions = new Aspose.Cells.Utility.JsonLayoutOptions();
                importOptions.ConvertNumericOrDate = true;
                importOptions.ArrayAsTable = true;
                importOptions.IgnoreArrayTitle = true;
                importOptions.IgnoreObjectTitle = true; 
                Aspose.Cells.Utility.JsonUtility.ImportData(rawResponse, cells, 0, 0, importOptions);

                workbook.Save(Path + "\\" + FileName);
            }
        }




    }
}
