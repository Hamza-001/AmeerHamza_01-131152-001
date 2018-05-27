<%@ Page Title="" Language="C#" MasterPageFile="~/MovieSiteMasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="VPProject.Home" EnableEventValidation="false" %>


<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="body" runat="server">

    <!-- banner -->
	<div id="slidey" style="display:none;">
         
		<ul>
            <asp:ListView ID="ListViewBanner" runat="server">
            <ItemTemplate>

                <li>
                    <img src="<%#  Eval("imagebanner")%>" alt=" " /><p class="title"><%# Eval("moviename")%></p>
                    <p class="description"><%# Eval("description") %></p>
                </li>
		</ItemTemplate>
        </asp:ListView> 
                
                </ul>  
            	
    </div>
    <script src="js/jquery.slidey.js"></script>
    <script src="js/jquery.dotdotdot.min.js"></script>
	   <script type="text/javascript">
			$("#slidey").slidey({
				interval: 8000,
				listCount: 5,
				autoplay: false,
				showList: true
			});
			$(".slidey-list-description").dotdotdot();
		</script>
<!-- //banner -->

<div class="general_social_icons">
	<nav class="social">
		<ul>
			<li class="w3_twitter"><a href="#">Twitter <i class="fa fa-twitter"></i></a></li>
			<li class="w3_facebook"><a href="#">Facebook <i class="fa fa-facebook"></i></a></li>			  
		</ul>
  </nav>
</div>
<!-- general -->
	<div class="general">
		<h4 class="latest-text w3_latest_text">Featured Movies</h4>
		<div class="container">
			<div class="bs-example bs-example-tabs" role="tabpanel" data-example-id="togglable-tabs">
				<ul id="myTab" class="nav nav-tabs" role="tablist">
					<li role="presentation" class="active"><a href="#home" id="home-tab" role="tab" data-toggle="tab" aria-controls="home" aria-expanded="true">Featured</a></li>
				</ul>
				<div id="myTabContent" class="tab-content">
					<div role="tabpanel" class="tab-pane fade active in" id="home" aria-labelledby="home-tab">
						<div class="w3_agile_featured_movies">



                            <asp:ListView ID="moviesList" runat="server">
                            <ItemTemplate>

							<div class="col-md-2 w3l-movie-gride-agile">
								<a href="singlemovie.aspx?id=<%# Eval("id") %>" class="hvr-shutter-out-horizontal"><img src="<%# Eval("image") %>" title="album-name" class="img-responsive" alt=" " />
									<div class="w3l-action-icon"><i class="fa fa-play-circle" aria-hidden="true"></i></div>
								</a>
								<div class="mid-1 agileits_w3layouts_mid_1_home">
									<div class="w3l-movie-text">
										<h6><a href="singlemovie.aspx?id=<%# Eval("id") %>"><%# Eval("moviename") %></a></h6>							
									</div>
									<div class="mid-2 agile_mid_2_home">
										<p><%# Eval("releaseyear") %></p>
										<div class="block-stars">
											<ul class="w3l-ratings">
												
											</ul>
										</div>
										<div class="clearfix"></div>
									</div>
								</div>
								<div class="ribben">
									<p>NEW</p>
								</div>
							</div>
                            </ItemTemplate>
                                </asp:ListView>
							
									<div class="clearfix"></div>
								</div>
							</div>
							<div class="ribben">
								<p>NEW</p>
							</div>
						</div>
						<div class="clearfix"> </div>
					</div>
				</div>
			</div>
		
</asp:Content>
