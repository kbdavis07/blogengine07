<%@ Control Language="C#" AutoEventWireup="true" EnableViewState="false" Inherits="BlogEngine.Core.Web.Controls.PostViewBase" %>
<article class="Post xfolkentry MainBox" id="post<%=Index %>">
    <h2 class="PostTitle"><a href="<%=Post.RelativeOrAbsoluteLink %>"><%=Server.HtmlEncode(Post.Title) %></a></h2>
    <div class="Postdetail">
        <span><%=Post.DateCreated.ToString("d. MMMM yyyy HH:mm") %></span> <span>by <a href="<%=BlogEngine.Core.Utils.AbsoluteWebRoot + "author/" + BlogEngine.Core.Utils.RemoveIllegalCharacters(Post.Author) + BlogEngine.Core.BlogConfig.FileExtension %>"><%=Post.AuthorProfile != null ? Post.AuthorProfile.DisplayName : Post.Author %></a></span> in <span><%=CategoryLinks(", ") %></span>
        <div class="CommentLink">
            <% if (BlogEngine.Core.BlogSettings.Instance.ModerationType == BlogEngine.Core.BlogSettings.Moderation.Disqus)
               { %>
            <a rel="nofollow" href="<%=Post.PermaLink %>#disqus_thread"><%=Resources.labels.comments %></a>
            <%}
               else
               { %>
            <a rel="nofollow" title="<%=Resources.labels.comments %>" href="<%=Post.RelativeOrAbsoluteLink %>#comment"><%=Post.ApprovedComments.Count %></a>

            <%} %>
        </div>
    </div>
    <div class="PostBody">
        <asp:PlaceHolder ID="BodyContent" runat="server" />
    </div>
    <div class="PostFoot">
        <div class="PostTags">
            Tags: <%=TagLinks(", ") %>
        </div>
        <div class="PostRating">
            <%=Rating %>
        </div>
        <%=AdminLinks %>
    </div>
</article>
