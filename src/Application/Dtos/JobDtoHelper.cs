﻿namespace Application.Dtos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using Domain;

    /// <summary>
    /// Класс для работы с JobDto
    /// </summary>
    public static class JobDtoHelper
    {
        #region Методы

        /// <summary>
        /// Преобразование списка JobDto в Job
        /// </summary>
        public static IEnumerable<Job> ConvertJobDtoListToJobList(IEnumerable<JobDto> vacanciesDto)
        {
            var vacancies = vacanciesDto.Select(x => new Job
            {
                Id = x.Id,
                Name = x.Name,
                SalaryFrom = x.SalaryFrom,
                SalaryTo = x.SalaryTo,
                EmployerName = x.EmployerName,
                ContactName = x.ContactName,
                Phone = x.Phone,
                Description = x.Description,
                EmploymentType = x.EmploymentType,
            });

            return vacancies;
        }

        /// <summary>
        /// Преобразование списка Job в JobDto
        /// </summary>
        public static IEnumerable<JobDto> ConvertJobListToJobDtoList(IEnumerable<Job> vacancies)
        {
            var vacanciesDto = vacancies.Select(x => new JobDto
            {
                Id = x.Id,
                Name = x.Name,
                SalaryFrom = x.SalaryFrom,
                SalaryTo = x.SalaryTo,
                EmployerName = x.EmployerName,
                ContactName = x.ContactName,
                Phone = x.Phone,
                Description = x.Description,
                EmploymentType = x.EmploymentType,
            });

            return vacanciesDto;
        }

        /// <summary>
        /// Преобразование Job в JobDto
        /// </summary>
        public static JobDto ConvertJobToJobDto(Job vacancy)
        {
            var vacancyDto = new JobDto
            {
                Id = vacancy.Id,
                Name = vacancy.Name,
                SalaryFrom = vacancy.SalaryFrom,
                SalaryTo = vacancy.SalaryTo,
                EmployerName = vacancy.EmployerName,
                ContactName = vacancy.ContactName,
                Phone = vacancy.Phone,
                Description = vacancy.Description,
                EmploymentType = vacancy.EmploymentType,
            };

            return vacancyDto;
        }

        #endregion
    }
}
