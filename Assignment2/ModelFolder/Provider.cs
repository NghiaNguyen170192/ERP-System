using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment2.ModelFolder
{
    public class Provider
    {
        private int id;
        private string name, address, phone, email, contactPerson, contactPhone, contactEmail;


        public Provider(int id, string name, string address, string phone, string email, string contactPerson, string contactPhone, string contactEmail)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.contactPerson = contactPerson;
            this.contactEmail = contactEmail;
            this.contactPhone = contactPhone;
        }

        public int Id { get { return this.id; } set { this.id = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public string Address { get { return this.address; } set { this.address = value; } }
        public string Phone { get { return this.phone; } set { this.phone = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string ContactPerson { get { return this.contactPerson; } set { this.contactPerson = value; } }
        public string ContactPhone { get { return this.contactPhone; } set { this.contactPhone = value; } }
        public string ContactEmail { get { return this.contactEmail; } set { this.contactEmail = value; } }

    }
}
