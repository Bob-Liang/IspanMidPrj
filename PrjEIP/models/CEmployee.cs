using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEIP.models
{
    public class CEmployee
    {
        public int fEmpId { get; set; }
        public string fEmpName { get; set; }
        public string fEmpGender { get; set; }
        public int fEmpAge { get; set; }
        public string fEmpMarriage { get; set; }
        public string fEmpStatus { get; set; }
        public string fEmpHireDate { get; set; }
        public string fEmpCreatedDate { get; set; }
        public string fEmpUpdatedDate { get; set; }
        public string fEmpPositionId { get; set; }
        public string fEmpGradeId { get; set; }
        public int fEmpSupervisorId { get; set; }
        public string fEmpDepartmentId { get; set; }
        public string fEmpBirthday { get; set; }
        public string fEmpPermissionId { get; set; }
        public string fEmpPhone { get; set; }
        public string fEmpAddress {  get; set; }
        public string fEmpEmail { get; set; }
        public string fEmpPassword { get; set; }
        public string fEmpPassword2 { get; set; }
        public string fEmpAccount { get; set; }
        public byte[] fEmpImage { get; set; }
        public string fEmpPersonalId { get; set; }

        public string CurrentUser {  get; set; }
    }
}
