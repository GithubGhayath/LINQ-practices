using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Dtos
{
    public class EmployeeDto
    {
        public string? EmployeeNo { get; set; }

        public string? Name { get; set; }

        public override string ToString()
        {
            return $"[{EmployeeNo}] - {Name}";
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            var other = (EmployeeDto)obj;
            return EmployeeNo == other.EmployeeNo && Name == other.Name;
        }
        public override int GetHashCode()
        {
            int hash = 17;

            // Check null
            if (EmployeeNo != null)
                hash = hash * 23 + EmployeeNo!.GetHashCode();

            if (Name != null)
                hash = hash * 23 + Name!.GetHashCode();

            return hash;
        }

    }
}
