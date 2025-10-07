using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping_Tutorial.Models;

namespace Shopping_Tutorial.Repository.Components
{
	public class FooterViewComponent : ViewComponent
	{
		private readonly DataContext _dataContext;
		public FooterViewComponent(DataContext context)
		{
			_dataContext = context;
		}
		public async Task<IViewComponentResult> InvokeAsync() 
		{
			var contact = await _dataContext.Contact.FirstOrDefaultAsync();
			if (contact == null)
			{
				// Return default contact info if none exists in database
				contact = new ContactModel
				{
					Name = "Laptop Selling Store",
					Email = "info@laptopselling.com",
					Phone = "0123-456-789",
					Description = "Chào mừng đến với cửa hàng laptop của chúng tôi",
					LogoImg = "default-logo.png",
					Map = ""
				};
			}
			return View(contact);
		}
	}
}
