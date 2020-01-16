﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using GreenMonkeysMVC.Data;
using GreenMonkeysMVC.Models;

namespace GreenMonkeysMVC.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
         
            EmployeeRepository employeeRepo = new EmployeeRepository();
            List<Employee> allEmployeesWithDepartments = employeeRepo.GetAllEmployeesWithDepartment();
        
            return View(allEmployeesWithDepartments);
        }

        /*
         * 
         * DepartmentRepository departmentRepo = new DepartmentRepository();
                        Department singleDepartment = departmentRepo.GetDepartmentById(departmentIdValue);
          // add to Instructors List
                    var returnedInstructors = await new InstructorsController(_config).allInstructorsList();
                    List<Instructor> instructorsList = new List<Instructor>(returnedInstructors);
                    cohorts.ForEach(c => c.Instructors.AddRange(instructorsList.Where(i => i.CohortId == c.Id)));
             */

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employees/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}