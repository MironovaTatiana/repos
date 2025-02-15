﻿using System.Threading.Tasks;

namespace Application.UseCases.DeleteJobsList
{
    /// <summary>
    /// Интерфейс для удаления вакансий
    /// </summary>
    public interface IDeleteJobsListUseCase
    {
        /// <summary>
        /// Выполнение
        /// </summary>
        Task ExecuteAsync();

        /// <summary>
        /// Установка выходного порта
        /// </summary>
        /// <param name="outputPort"></param>
        void SetOutputPort(IOutputPort outputPort);
    }
}
