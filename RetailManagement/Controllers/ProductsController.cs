
using System.Threading.Tasks;
using DAL.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

using RetailManagement.Commands;

using RetailManagement.Queries;

namespace RetailManagement.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            var viewmodel = await _mediator.Send(new GetProductsQuery());
            return View(viewmodel);
        }

        //GET: Products/Details/5
        public async Task<IActionResult> Details(int id)
        {

            var product = await _mediator.Send(new GetProductByIdQuery(id));

            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {         
            return View();
        }

        //    // POST: Products/Create
        //    // To protect from overposting attacks, enable the specific properties you want to bind to.
        //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            var viewModel = await _mediator.Send(new InsertProductCommand(product));
            return RedirectToAction(nameof(Index));
        }

        //    // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));
            return View(product);
        }

        //    // POST: Products/Edit/5
        //    // To protect from overposting attacks, enable the specific properties you want to bind to.
        //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Product product)
        {
              await _mediator.Send(new EditProductCommand(product));
       
              return RedirectToAction(nameof(Index));
        }

        //    // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return View();
        }

        //    // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _mediator.Send(new DeleteProductCommand(id));
            return RedirectToAction(nameof(Index));
        }

    }
}
