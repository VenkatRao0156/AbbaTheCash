using System;
using MongoDB.Bson;
using Realms;

namespace AbbaTheCash.Models
{
	public class UserDeatilsModel: RealmObject
    {
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [MapTo("firstName")]
        [Required]
        public string FirstName { get; set; }

        [MapTo("lastName")]
        [Required]
        public string LastName { get; set; }

        [MapTo("phoneNumber")]
        [Required]
        public string PhoneNumber { get; set; }

        [MapTo("emailID")]
        [Required]
        public string EmailID { get; set; }

        [MapTo("panCard")]
        [Required]
        public string PanCard { get; set; }

        [MapTo("pswd")]
        [Required]
        public string Pswd { get; set; }

        [MapTo("_partition")]
        [Required]
        public string Partition { get; set; }
    }
}