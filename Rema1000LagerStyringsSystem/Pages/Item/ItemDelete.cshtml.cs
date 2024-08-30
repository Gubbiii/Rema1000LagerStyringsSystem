using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Rema1000LagerStyringsSystem
{
    public class ItemDeleteModel : PageModel
    {
        private IItem repo;
        [BindProperty]
        public Item item { get; set; }
        public ItemDeleteModel(IItem repository)
        {
            repo = repository;
        }
        public IActionResult OnGet(int Id)
        {
            item = repo.GetItem(Id);
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            repo.RemoveItem(id);
            return RedirectToPage("ItemPrint");
        }
    }
}

