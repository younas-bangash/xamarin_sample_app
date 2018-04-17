using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp.Core.Utils
{
    public class TourModelClass
    {

        // Title text for the tour:
        public string title;

        // Title text for the tour:
        public string message;

        // Returns the title text for the tour screen:
        public string Title { get { return title; } }

        public string Message { get { return message; } }
    }


    // Tree catalog: holds image resource IDs and caption text:
    public class TourInit
    {
        // Built-in tree catalog (could be replaced with a database)
        static TourModelClass[] tourData = {
            new TourModelClass {
                title = "No.1: The Larch",
                message = "No.1: The Larch"
            },
            new TourModelClass {
                title = "No.1: The Larch",
                message = "No.1: The Larch"
            },
            new TourModelClass {
                title = "No.1: The Larch",
                message = "No.1: The Larch"
            },
            new TourModelClass {
                title = "No.1: The Larch",
                message = "No.1: The Larch"
            },
            new TourModelClass {
                title = "No.1: The Larch",
                message = "No.1: The Larch"
            }

        };
        
        // Indexer (read only) for accessing a tree page:
        public TourModelClass this[int i] { get { return tourData[i]; } }
    }
}
