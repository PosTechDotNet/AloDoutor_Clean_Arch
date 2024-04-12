﻿using AloDoutor.Domain.Entity;
using FluentValidation.Results;

namespace AloDoutor.Application.Interfaces
{
    public interface IAgendamentoService
    {
        Task<ValidationResult> Adicionar(Agendamento especialidade);
        Task<ValidationResult> Reagendar(Guid id, DateTime data);
        Task<ValidationResult> Cancelar(Guid id);
        Task<Agendamento> ObterPorId(Guid id);
        Task<IEnumerable<Agendamento>> ObterTodos();
        Task<IEnumerable<Agendamento>> ObterAgendamentosPorIStatus(int status);
    }
}
