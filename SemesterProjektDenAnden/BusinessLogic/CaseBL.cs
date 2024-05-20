﻿using BusinessLogic.BLInterfaces;
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
            

            List<TransportLog> transportLogs = new List<TransportLog>();
            transportLogs = await new TransportLogBL().GetAllAsync(caseId);

            List<WorkLog> workLogs = new List<WorkLog>();
            workLogs = await new WorkLogBL().GetAllAsync(caseId);

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
                ws.Cells["B8"].Style.Numberformat.Format = "yyyy-mm-dd HH:mm";
                ws.Cells["A9"].Value = "Expected Hours";
                ws.Cells["B9"].Value = case_.EstHours;
                ws.Cells["A10"].Value = "End Date";
                ws.Cells["B10"].Value = case_.ExEndDate;
                ws.Cells["B10"].Style.Numberformat.Format = "yyyy-mm-dd HH:mm";
                ws.Cells["E1"].Value = "Transport ID";
                ws.Cells["F1"].Value = "Transport KM";
                ws.Cells["G1"].Value = "Transport Description";
                int i = 2;
                foreach (var item in transportLogs)
                {
                    
                    ws.Cells["E" + i].Value = item.TransportLogId;
                    ws.Cells["F" + i].Value = item.KmDriven;
                    ws.Cells["G" +i].Value = item.LogDescription;
                    i++;
                }

                ws.Cells["E" + i].Value = "Total KM";
                ws.Cells["F" + i].Formula = $"SUM(F2:F{i-1})";

                
                ws.Cells["J1"].Value = "WorkLog Description";
                ws.Cells["K1"].Value = "Start Date";
                ws.Cells["L1"].Value = "End Date";
                ws.Cells["M1"].Value = "Service ID";
                i = 2;
                foreach (var item in workLogs)
                {
                    ws.Cells["J" + i].Value = item.WorkDescription;
                    ws.Cells["K" + i].Value = item.StartDate;
                    ws.Cells["K" + i].Style.Numberformat.Format = "yyyy-mm-dd HH:mm";
                    ws.Cells["L" + i].Value = item.EndDate;
                    ws.Cells["L" + i].Style.Numberformat.Format = "yyyy-mm-dd HH:mm";
                    ws.Cells["M" + i].Value = item.ServiceId;
                    i++;
                }
                ws.Cells[ws.Dimension.Address].AutoFitColumns();
                

                package.Save();
            }   

        }
    }
}
