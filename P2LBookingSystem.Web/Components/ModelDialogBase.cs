using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using P2LBookingSystem.Models;
using P2LBookingSystem.Web.Services;

namespace P2LBookingSystem.Web.Components
{
    public class ModelDialogBase : ComponentBase
    {
        [Inject] public IBookingService BookingService { get; set; }
        [Inject] public IResourceService ResourceService { get; set; }
        public IEnumerable<Booking> Bookings { get; set; }
        public string Text { get; set; }
        public enum StatusOfText
        {
            Success,
            Error
        }
        public StatusOfText TextType { get; set; }
        public Booking newBooking = new Booking();

        [Parameter]
        public Resource Resource { get; set; }
        [Parameter]
        public EventCallback<bool> OnClose { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Bookings = (await BookingService.GetBookings()).ToList();
        }

        protected Task ModalCancel()
        {
            return OnClose.InvokeAsync(false);
        }

        protected void ModalBook()
        {
            if (IsAvailableBooking())
            {
                int max = Bookings.Max(b => b.Id);
                newBooking.Id = (++max);
                newBooking.ResourceId = Resource.Id;
                BookingService.AddBooking(newBooking);
                Console.WriteLine($"EMAIL SENT TO admin@admin.com FOR CREATED BOOKING WITH ID {Resource.Id}");
                TextType = StatusOfText.Success;
                Text =
                    $"Success, resource {Resource.Id} booked between {newBooking.DateFrom} - {newBooking.DateTo}, quantity: {newBooking.BookedQuantity}";
            }
        }

        private bool IsAvailableBooking()
        {
            if (newBooking.DateFrom == newBooking.DateTo || newBooking.BookedQuantity.Equals(0))
            {
                TextType = StatusOfText.Error;
                Text = $"Invalid input";
                return false;
            }
            if (Resource.Quantity < newBooking.BookedQuantity)
            {
                TextType = StatusOfText.Error;
                Text = $"Could not book resource {Resource.Id}, not enough in stock";
                return false;
            }
            IList<Booking> overlappingBookingsOfResource = Bookings.Where(b => b.ResourceId == Resource.Id && (newBooking.DateFrom < b.DateTo || newBooking.DateTo > b.DateFrom)).ToList();
            int bookedQ = overlappingBookingsOfResource.Sum(b => b.BookedQuantity);
            Console.WriteLine(bookedQ);
            if (bookedQ == Resource.Quantity || bookedQ + newBooking.BookedQuantity > Resource.Quantity)
            {
                TextType = StatusOfText.Error;
                Text = $"Could not book resource {Resource.Id}, not enough amount for given dates";
                return false;
            }
            return true;
        }
    }
}