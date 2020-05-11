using AjaxLabServerSide.Models;
using AjaxLabServerSide.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AjaxLabServerSide.Controllers
{
    public class TreeStructureController : ApiController
    {
        public int counterId = 0;
        // GET api/TreeStructure
        public FilesDictoryDetails Get()
        {
            var list = new List<FilesDictoryDetails>();
            var rootDetails = new FilesDictoryDetails() { SubChildren = list, Name = "AjaxLabServerSide" };
            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(@"C:\Users\mihalutf\Desktop\Facultate - Anul 2\Semestrul II\Programare Web\Laborator\lab5\AjaxLabServerSide");

            rootDetails.AllChildren = WalkDirectoryTree(root, list);
            counterId = 0;
            return rootDetails;
        }

        // GET api/TreeStructure/5
        public FilesDictoryDetails Get(int id)
        {
            var list = new List<FilesDictoryDetails>();
            var rootDetails = new FilesDictoryDetails() { SubChildren = list, Name = "AjaxLabServerSide" };
            System.IO.DirectoryInfo root = new System.IO.DirectoryInfo(@"C:\Users\mihalutf\Desktop\Facultate - Anul 2\Semestrul II\Programare Web\Laborator\lab5\AjaxLabServerSide");

            rootDetails.AllChildren = WalkDirectoryTree(root, list);
            var file = rootDetails.AllChildren.Find(x => x.Id == id);

            if(file.AllChildren == null)
            {
                file.IsFile = true;
                file.Text = File.ReadAllText(file.Path);           
            }

            counterId = 0;
            return file;
        }

        // POST api/TreeStructure
        public void Post([FromBody]string value)
        {
        }

        // PUT api/TreeStructure/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/TreeStructure/5
        public void Delete(int id)
        {
        }
        private List<FilesDictoryDetails> WalkDirectoryTree(System.IO.DirectoryInfo root, List<FilesDictoryDetails> subChildren)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;
            var allChildren = new List<FilesDictoryDetails>();

            try
            {
                files = root.GetFiles("*.*");
            }
            catch (UnauthorizedAccessException)
            {
            }
            catch (System.IO.DirectoryNotFoundException)
            {
            }
            catch(Exception)
            {

            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    var file = new FilesDictoryDetails() { Id = ++counterId, IsFile = true, Name = fi.Name, Path = fi.FullName };
                    subChildren.Add(file);
                    allChildren.Add(file);
                }

                // Now find all the subdirectories under this directory.
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Resursive call for each subdirectory.
                    var listOfDirectory = new List<FilesDictoryDetails>();
                    var children = WalkDirectoryTree(dirInfo, listOfDirectory);
                    var directory = new FilesDictoryDetails() { Id = ++counterId, Name = dirInfo.Name, SubChildren = listOfDirectory, Path = dirInfo.FullName, AllChildren = children };
                    subChildren.Add(directory);
                    allChildren.Add(directory);
                    allChildren = allChildren.Concat(children).ToList();

                }
            }

            return allChildren;
        }
    }
}
