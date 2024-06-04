using DataAcces;
using Models;
using Models.Interfaces;
using OfficeOpenXml;



namespace BusinessLogic
{
    public class CaseBL : ICase
    {
        CaseDA caseDA = new CaseDA();

        

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

        public async void printRapport(int caseId, string path)
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
            using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
            {

                ws = package.Workbook.Worksheets.Add(case_.CaseTitle);
                ws.Cells["A1"].Value = "Case ID";
                ws.Cells["B1"].Value = case_.CaseId;
                ws.Cells["A2"].Value = "Case Title";
                ws.Cells["B2"].Value = case_.CaseTitle;
                ws.Cells["A3"].Value = "Start Date";
                ws.Cells["B3"].Value = case_.StartDate;
                ws.Cells["B3"].Style.Numberformat.Format = "yyyy-mm-dd HH:mm";
                ws.Cells["A4"].Value = "Expected Hours";
                ws.Cells["B4"].Value = case_.EstHours;
                ws.Cells["A5"].Value = "End Date";
                ws.Cells["B5"].Value = case_.ExEndDate;
                ws.Cells["B5"].Style.Numberformat.Format = "yyyy-mm-dd HH:mm";


                ws.Cells["A9"].Value = "Client Name";
                ws.Cells["B9"].Value = client.FirstName + " " + client.LastName;
                ws.Cells["A10"].Value = "Client Mail";
                ws.Cells["B10"].Value = client.Mail;
                ws.Cells["A11"].Value = "Client Phone";
                ws.Cells["B11"].Value = client.Phone;



                ws.Cells["A13"].Value = "Employee ID";
                ws.Cells["B13"].Value = employee.Id;
                ws.Cells["A14"].Value = "Employee Name";
                ws.Cells["B14"].Value = employee.FirstName + " " + employee.LastName;
                ws.Cells["A15"].Value = "Employee Phone";
                ws.Cells["B15"].Value = employee.PhoneNumber;
                ws.Cells["A16"].Value = "Employee Mail";
                ws.Cells["B16"].Value = employee.Email;

                ws.Cells["E1"].Value = "Transport ID";
                ws.Cells["F1"].Value = "Transport KM";
                ws.Cells["G1"].Value = "Transport Description";
                int i = 2;
                foreach (TransportLog item in transportLogs)
                {

                    ws.Cells["E" + i].Value = item.TransportLogId;
                    ws.Cells["F" + i].Value = item.KmDriven;
                    ws.Cells["G" + i].Value = item.LogDescription;
                    i++;
                }

                ws.Cells["E" + i].Value = "Total KM";
                ws.Cells["F" + i].Formula = $"SUM(F2:F{i - 1})";
                ws.Cells["E" + i+1].Value = "Total cost";
                ws.Cells["F" + i+1].Formula = $"SUM(F2:F{i - 1})*4";
                ws.Cells["F" + i+1].Style.Numberformat.Format = "0.00";



                ws.Cells["J1"].Value = "WorkLog Description";
                ws.Cells["K1"].Value = "Start Date";
                ws.Cells["L1"].Value = "End Date";
                ws.Cells["M1"].Value = "Service ID";
                i = 2;
                foreach (WorkLog item in workLogs)
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
