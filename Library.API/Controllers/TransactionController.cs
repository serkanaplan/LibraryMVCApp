using AutoMapper;
using Library.Core.DTOs;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace Library.API.Controllers
{
    public class TransactionController:BaseController   
    {
        private readonly ITransactionService _transactionService;
        private readonly IMapper _mapper;

        public TransactionController(ITransactionService transactionService, IMapper mapper)
        {
            _transactionService = transactionService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var transactions = await _transactionService.GetAllAsync();
            var transactionDtos = _mapper.Map<IEnumerable<TransactionDTO>>(transactions.ToList());

            return Ok(transactionDtos);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var transaction = await _transactionService.GetByIdAsync(id);
                var transactionDtos = _mapper.Map<TransactionDTO>(transaction);
                return Ok(transactionDtos);
            }
            catch (Exception)
            {

               return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Save(TransactionDTO transactionDto)
        {
            try
            {
                var transaction = await _transactionService.AddAsync(_mapper.Map<Transaction>(transactionDto));
                var transactionDtos = _mapper.Map<TransactionDTO>(transaction);
                return Ok(transactionDtos);
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, TransactionDTO transactionDto)
        {
            try
            {
                await _transactionService.UpdateAsync(_mapper.Map<Transaction>(transactionDto));
                return NoContent();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Remove(int id)
        {
            try
            {
                var transaction = await _transactionService.GetByIdAsync(id);
                await _transactionService.RemoveAsync(transaction);
                return NoContent();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
