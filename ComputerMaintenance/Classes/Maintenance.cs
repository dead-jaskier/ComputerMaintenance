using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using ComputerMaintenance.Classes;
using ComputerMaintenance.Classes.Interfaces;

namespace ComputerMaintenance.Classes
{
    public class Maintenance : IMaintenance
    {
        // Directories to check
        private string[] _checkDir { get; set; }
        // Directory to set for queued objects
        private string _queueDir { get; set; }
        private string _delDir { get; set; }
        // Sets flag to wipe '_delDir' location
        private bool _delete { get; set; }
        
        public Maintenance (string[] checkDir, string queueDir, string delDir, bool delete = false)
        {
            _checkDir = checkDir;
            _queueDir = queueDir;
            _delDir = delDir;
            _delete = delete;
        }


        /// <summary>
        /// Method to fire off the deletion of the '_delDir' property. 
        /// </summary>
        /// <returns>This method returns void.</returns>
        public void FireDelete()
        {
            // Delete flag was sent- delete everything within the Del dir
            if (_delete)
            {
                foreach (string file in Directory.GetFiles(_delDir))
                {
                    File.Delete(file);
                }
            }
        }
    }
}
