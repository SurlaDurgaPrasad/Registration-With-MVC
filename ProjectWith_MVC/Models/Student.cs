using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace ProjectWith_MVC.Models
{
    public class Student
    {
        [Required(ErrorMessage = "please enter the rollNumber")]

        public int StuRollNum { get; set; }

        [Required(ErrorMessage = "please enter the StudentName")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Minumum char is 5 and maximum char is 50")]
        public string Sname { get; set; }

        [Required(ErrorMessage = "please enter the Fee")]
        [MinLength(1, ErrorMessage = "please enter atleast  1 digit")]
        [MaxLength(5, ErrorMessage = "please enter lessthan are equal to 5")]
        public string Fee { get; set; }

        [Display(Name = "Mobile Number:")]
        [Required(ErrorMessage = "Mobile Number is required.")]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "please enter the Email.Id")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }
        public string city { get; set; }//drop down 
        public string Course { get; set; }//checkckbox

        public SqlConnection Connection()
        {
            string connection = ConfigurationManager.ConnectionStrings["ConnectiontoDB"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            return con;
        }
        public void AddDetails(Student obj)
        {
            var con = Connection();
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Project values('"+ obj.StuRollNum + "','" + obj.Sname + "','" + obj.Fee+ "','" +obj.PhoneNo + "','"+obj.Email + "','"+obj.city + "','"+obj.Course+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();


        }

    }

}