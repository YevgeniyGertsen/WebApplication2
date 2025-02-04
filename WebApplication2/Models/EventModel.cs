namespace WebApplication2.Models
{
    /*
     
       <div class="single-event col-md-8 col-sm-8 col-xs-12 photography">
                <div class="single-event-item">
                    <img src="img/event/5.jpg" alt="">
                    <div class="event-text">
                        <h3 class="event-title">management conferences</h3>
                        <h3 class="author-name">By : Dan Brown</h3>
                        <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt</p>
                    </div>
                </div>
            </div>
     */
    public enum PictireSize { small, big}

    public class EventModel
    {
        public int Id { get; set; }

        //<img src="img/event/5.jpg" alt="">
        public string EventImgPath { get; set; }

        public PictireSize PictireSize { get; set; }

        // <h3 class="event-title">management conferences</h3>
        public string EventTitle { get; set; }

        //<h3 class="author-name">By : Dan Brown</h3>
        public string AuthorName { get; set; }

        public string Description { get; set; }

    }
}
