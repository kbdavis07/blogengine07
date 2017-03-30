<%@ Control Language="C#" EnableViewState="False" Inherits="BlogEngine.Core.Web.Controls.CommentViewBase" %>
<div id="id_<%=Comment.Id %>" class="Comment<%= Post.Author.Equals(Comment.Author, StringComparison.OrdinalIgnoreCase) ? " self" : "" %>">
    <div class="ItemComment ClearFix">
        <div class="ItemHeaerComment">
            <%= Comment.Website != null ? "<a href=\"" + Comment.Website + "\" rel=\"nofollow\" class=\"url fn\">" + Comment.Author + "</a>" : "<span class=\"fn\">" +Comment.Author + "</span>" %>
            <span class="Right">
                <span class="PubCommentDate"><%= Comment.DateCreated %>  </span>
                <span class="FlagItemComment"><%= Flag %> </span>
                <a class="ItemNumComment" href="#id_<%=Comment.Id %>">#</a>
            </span>
        </div>
        <div class="Clear"></div>
        <span class="Left Gravatar"><%= Gravatar(108)%></span>
        <p class="content"><%= Text %></p>
        <p class="author">
            <%= AdminLinks.Length > 2 ? AdminLinks.Substring(2) : AdminLinks %>
            <span style="float: right"><%=ReplyToLink%></span>
        </p>
        <div class="Clear"></div>
    </div>
    <div class="comment-replies" id="replies_<%=Comment.Id %>" <%= (Comment.Comments.Count == 0 || Comment.Email == "pingback" || Comment.Email == "trackback") ? " style=\"display:none;\"" : "" %>>
        <asp:PlaceHolder ID="phSubComments" runat="server" />
    </div>
</div>
