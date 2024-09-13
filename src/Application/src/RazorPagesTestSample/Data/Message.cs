using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the text of the message.
        /// </summary>
        /// <remarks>
        /// This property is required and must not exceed 200 characters.
        /// If the message exceeds this limit, an error message will be provided:
        /// "There's a 250 character limit on messages. Please shorten your message."
        /// </remarks>
        /// /// /// /// /// /// /// /// [Required]
        [DataType(DataType.Text)]
        [StringLength(250, ErrorMessage = "There's a 250 character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
