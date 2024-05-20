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

            List<TransportLog> transportLogs = new List<TransportLog>();
            transportLogs.Add(transport);

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            ExcelWorksheet ws;
            using (var package = new ExcelPackage( new FileInfo(@"C:\Users\Frederik\Desktop\pokemon\games\pokemondecomp\SemesterProjektDenAnden\SemesterProjektDenAnden\SemesterProjektDenAnden\bin\Debug\net6.0-windows\mysheet.xlsx")))
            {
                ws = package.Workbook.Worksheets.Add(case_.CaseTitle);
                ws.Cells["A1"].Value = "Case ID";
                ws.Cells["B1"].Value = case_.CaseId;
                ws.Cells["A2"].Value = "Case Title";
                ws.Cells["B2"].Value = case_.CaseTitle;
                ws.Cells["A3"].Value = "Client Name";
                ws.Cells["B3"].Value = client.FirstName + " " + client.LastName;
                ws.Cells["A4"].Value = "Client Mail";
                ws.Cells["B4"].Value = client.Mail;
                ws.Cells["A5"].Value = "Client Phone";
                ws.Cells["B5"].Value = client.Phone;
                ws.Cells["A6"].Value = "Employee ID";
                ws.Cells["B6"].Value = employee.Id;
                ws.Cells["A7"].Value = "Employee Name";
                ws.Cells["B7"].Value = employee.FirstName + " " + employee.LastName;
                ws.Cells["A8"].Value = "Start Date";
                ws.Cells["B8"].Value = case_.StartDate;
                ws.Cells["A9"].Value = "Expected Hours";
                ws.Cells["B9"].Value = case_.EstHours;
                ws.Cells["A10"].Value = "End Date";
                ws.Cells["B10"].Value = case_.ExEndDate;
                ws.Cells["E1"].Value = "Transport ID";
                ws.Cells["F1"].Value = transport.TransportLogId;
                ws.Cells["E2"].Value = "Transport KM";
                ws.Cells["F2"].Value = transport.KmDriven;
                ws.Cells["E3"].Value = "Transport Description";
                ws.Cells["F3"].Value = transport.LogDescription;
                package.Save();
            }   

        }
    }
}
