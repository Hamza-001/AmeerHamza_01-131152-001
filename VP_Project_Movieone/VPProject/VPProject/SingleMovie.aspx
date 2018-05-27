<%@ Page Title="" Language="C#" MasterPageFile="~/MovieSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="SingleMovie.aspx.cs" Inherits="VPProject.SingleMovie" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Movie Review
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">
    <!-- single -->
    <div class="single-page-agile-main">
    <div class="container">
		    <!-- /w3l-medile-movies-grids -->
			    <div class="agileits-single-top">
				    <ol class="breadcrumb">
				      <li><a href="index.html">Home</a></li>
				      <li class="active">Single</li>
				    </ol>
			    </div>
			    <div class="single-page-agile-info">
                       <!-- /movie-browse-agile -->
                               <div class="show-top-grids-w3lagile">
				    <div class="col-sm-12 single-middle">
                        <asp:ListView ID="dataView" runat="server">
                            <ItemTemplate>
					    <div class="song">
						    <div class="song-info">
							    <h3><%# Eval("moviename") %></h3>	
					    </div>
						    <div class="video-grid-single-page-agileits">
							    <div data-video="<%# Eval("trailer") %>" id="video"> <img src="<%# Eval("imagebanner") %>" alt="" class="img-responsive" /> </div>
						    </div>
					    </div>
                                </ItemTemplate>
                        </asp:ListView>
					    <div class="song-grid-right">
						    <div class="share">
							    <h4>
                                    <asp:Label ID="ratingLabel" runat="server" Font-Bold="False" Text="Rating: "></asp:Label>
                                    <asp:Label ID="ratingCount" runat="server" Text="0"></asp:Label>
                                    <image src="images/star.png" width="20px" height="20px"></image>
                                </h4>
                                <p>
                                    &nbsp;</p>
                                <h6>
                                    <asp:Label ID="totalReviews" runat="server" Text="Total Reviews: "></asp:Label>
                                    <asp:Label ID="totalReviewsLabel" runat="server" Text="0"></asp:Label>
                                </h6>
                                <p>&nbsp;</p>
                                <h5>Share this</h5>
							    <div class="single-agile-shar-buttons">
							    <ul>
								    <li>
									    <div class="fb-like" data-href="https://www.facebook.com/w3layouts" data-layout="button_count" data-action="like" data-size="small" data-show-faces="false" data-share="false"></div>
									    <script>(function(d, s, id) {
									      var js, fjs = d.getElementsByTagName(s)[0];
									      if (d.getElementById(id)) return;
									      js = d.createElement(s); js.id = id;
									      js.src = "//connect.facebook.net/en_GB/sdk.js#xfbml=1&version=v2.7";
									      fjs.parentNode.insertBefore(js, fjs);
									    }(document, 'script', 'facebook-jssdk'));</script>
								    </li>
								    <li>
									    <div class="fb-share-button" data-href="https://www.facebook.com/w3layouts" data-layout="button_count" data-size="small" data-mobile-iframe="true"><a class="fb-xfbml-parse-ignore" target="_blank" href="https://www.facebook.com/sharer/sharer.php?u=https%3A%2F%2Fwww.facebook.com%2Fw3layouts&amp;src=sdkpreparse">Share</a></div>
								    </li>
                                   
								    <li class="news-twitter">
									    <a href="https://twitter.com/w3layouts" class="twitter-follow-button" data-show-count="false">Follow @w3layouts</a><script async src="//platform.twitter.com/widgets.js" charset="utf-8"></script>
								    </li>
								    <li>
									    <a href="https://twitter.com/intent/tweet?screen_name=w3layouts" class="twitter-mention-button" data-show-count="false">Tweet to @w3layouts</a><script async src="//platform.twitter.com/widgets.js" charset="utf-8"></script>
								    </li>
								    <li>
									   
								    </li>
							    </ul>
						    </div>
						    </div>
					    </div>
					    <div class="clearfix"> </div>

					    <div class="all-comments">
						    <div class="all-comments-info">
							    <h3>Reviews</h3>
                                <p>&nbsp;</p>
                                <p>
                                    &nbsp;</p>
                                <p>&nbsp;</p>
                                <p>
                                    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource2" Height="50px" Width="125px">
                                        <EditRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                        <Fields>
                                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                            <asp:BoundField DataField="review" HeaderText="review" SortExpression="review" />
                                            <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
                                            <asp:CommandField ShowInsertButton="True" />
                                        </Fields>
                                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                        <RowStyle BackColor="White" ForeColor="#330099" />
                                    </asp:DetailsView>
                                </p>
                                <p>&nbsp;</p>
                                <p>
                                    <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource3" Height="50px" Width="125px">
                                        <EditRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                        <Fields>
                                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                            <asp:BoundField DataField="review" HeaderText="review" SortExpression="review" />
                                            <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
                                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
                                        </Fields>
                                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                        <RowStyle BackColor="White" ForeColor="#330099" />
                                    </asp:DetailsView>
                                </p>
                                <p>
                                    &nbsp;</p>
                                <p>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MoviesDBConnectionString %>" SelectCommand="SELECT [id], [user_id], [review], [rating] FROM [MovieReview]"></asp:SqlDataSource>
                                </p>
                                <p>
                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MoviesDBConnectionString %>" DeleteCommand="DELETE FROM [MovieReview] WHERE [id] = @id" InsertCommand="INSERT INTO [MovieReview] ([review], [rating]) VALUES (@review, @rating)" SelectCommand="SELECT [id], [review], [rating] FROM [MovieReview] WHERE ([id] = @id)" UpdateCommand="UPDATE [MovieReview] SET [review] = @review, [rating] = @rating WHERE [id] = @id">
                                        <DeleteParameters>
                                            <asp:Parameter Name="id" Type="Int32" />
                                        </DeleteParameters>
                                        <InsertParameters>
                                            <asp:Parameter Name="review" Type="String" />
                                            <asp:Parameter Name="rating" Type="Double" />
                                        </InsertParameters>
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
                                        </SelectParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="review" Type="String" />
                                            <asp:Parameter Name="rating" Type="Double" />
                                            <asp:Parameter Name="id" Type="Int32" />
                                        </UpdateParameters>
                                    </asp:SqlDataSource>
                                </p>
                                <p>
                                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:MoviesDBConnectionString %>" DeleteCommand="DELETE FROM [MovieReview] WHERE [id] = @id" InsertCommand="INSERT INTO [MovieReview] ([review], [rating]) VALUES (@review, @rating)" SelectCommand="SELECT [id], [review], [rating] FROM [MovieReview] WHERE (([id] = @id) AND ([user_id] = @user_id))" UpdateCommand="UPDATE [MovieReview] SET [review] = @review, [rating] = @rating WHERE [id] = @id">
                                        <DeleteParameters>
                                            <asp:Parameter Name="id" Type="Int32" />
                                        </DeleteParameters>
                                        <InsertParameters>
                                            <asp:Parameter Name="review" Type="String" />
                                            <asp:Parameter Name="rating" Type="Double" />
                                        </InsertParameters>
                                        <SelectParameters>
                                            <asp:ControlParameter ControlID="GridView1" Name="id" PropertyName="SelectedValue" Type="Int32" />
                                            <asp:SessionParameter Name="user_id" SessionField="userID" Type="Int32" />
                                        </SelectParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="review" Type="String" />
                                            <asp:Parameter Name="rating" Type="Double" />
                                            <asp:Parameter Name="id" Type="Int32" />
                                        </UpdateParameters>
                                    </asp:SqlDataSource>
                                </p>
						    </div>
					    </div>
				    </div>
				 

				
				    <div class="clearfix"> 
                                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="id" DataSourceID="SqlDataSource1">
                                        <Columns>
                                            <asp:CommandField ShowSelectButton="True" />
                                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                            <asp:BoundField DataField="user_id" HeaderText="user_id" SortExpression="user_id" />
                                            <asp:BoundField DataField="review" HeaderText="review" SortExpression="review" />
                                            <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
                                        </Columns>
                                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                                        <RowStyle BackColor="White" ForeColor="#330099" />
                                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                                        <SortedAscendingCellStyle BackColor="#FEFCEB" />
                                        <SortedAscendingHeaderStyle BackColor="#AF0101" />
                                        <SortedDescendingCellStyle BackColor="#F6F0C0" />
                                        <SortedDescendingHeaderStyle BackColor="#7E0000" />
                                    </asp:GridView>
                                   </div>
			    </div>
			
						
							 
				    </div>
				    <!-- //w3l-latest-movies-grids -->
			    </div>	
		    </div>
	<!-- //w3l-medile-movies-grids -->
</asp:Content>
