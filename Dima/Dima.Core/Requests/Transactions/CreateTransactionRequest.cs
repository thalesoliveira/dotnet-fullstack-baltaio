using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dima.Core.Enums;

namespace Dima.Core.Requests.Transactions
{
    public class CreateTransactionRequest : Request
    {
        [Required(ErrorMessage = "Titulo invalido")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tipo inválido")]
        public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

        [Required(ErrorMessage = "Valor inválido")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Categoria inválida")]
        public long CategoryId { get; set; }

        [Required(ErrorMessage = "Data inválida")]
        public DateTime? PaidOrReceivedAt { get; set; }
    }
}