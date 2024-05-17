using BusinessLogic.BLInterfaces;
using DataAcces;
using DataAcces.DAInterfaces;
using Models;
using Newtonsoft.Json;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CaseBL : ICaseBL
    {
        ICase caseDA = new CaseDA();

        public async Task<bool> CreateAsync(Case newCase)
        {
            bool result = await caseDA.CreateAsync(newCase);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Case> GetAsync(int id)
        {
            Case case_ = await caseDA.GetAsync(id);
            return case_;
        }

        public async Task<List<Case>> GetAllAsync()
        {
            List<Case> result = await caseDA.GetAllAsync();
            return result;
        }

        public async Task<bool> UpdateAsync(Case newCase)
        {
            bool result = await caseDA.UpdateAsync(newCase);
            return result;

        }

        public async Task<List<Case>> GetCaseWithClientIdAsync(int id)
        {
            List<Case> clientCases = await caseDA.GetCaseWithClientIdAsync(id);
            return clientCases;
        }

        public async void printRapport(int caseId)
        {
            Case case_ = new Case();
            case_ = await GetAsync(caseId);
            
            Employee employee = new Employee();
            employee = await new EmployeeBL().GetAsync(case_.EmployeeId);

            Client client = new Client();
            client = await new ClientBL().GetAsync(case_.ClientId);

            TransportLog transport = new TransportLog();
            transport = await new TransportLogBL().GetAsync(caseId);


            DataTable dt = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(case_), (typeof(DataTable)));
            FileInfo fileInfo = new FileInfo("Rapport.txt");
            var excel = new ExcelPackage(fileInfo);
            var ws = excel.Workbook.Worksheets.Add("Rapport");
            ws.Cells["A1"].LoadFromDataTable(dt, true);
            excel.Save();
            //Console.WriteLine("Case ID: " + case_.CaseId);
            //Console.WriteLine("Case Title: " + case_.CaseTitle);
            //Console.WriteLine("Client Name: " + client.FirstName + " " + client.LastName);
            //Console.WriteLine("Client Mail: " + client.Mail);
            //Console.WriteLine("Client Phone: " + client.Phone);
            //Console.WriteLine("Employee ID: " + employee.Id);
            //Console.WriteLine("Employee Name: " + employee.FirstName + " " + employee.LastName);
            //Console.WriteLine("Start Date: " + case_.StartDate);
            //Console.WriteLine("Expected Hours: " + case_.EstHours);
            //Console.WriteLine("End Date: " + case_.ExEndDate);
            //Console.WriteLine("Transport ID: " + transport.TransportLogId);
            //Console.WriteLine("Transport KM: " + transport.KmDriven);
            //Console.WriteLine("Transport Description: " + transport.LogDescription);

        }
    }
}
