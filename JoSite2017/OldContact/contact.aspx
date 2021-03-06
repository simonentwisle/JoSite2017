﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="JoSite2017.contact" %>

<!DOCTYPE html>
<!-- This site was created in Webflow. http://www.webflow.com--><!-- Last Published: Tue May 23 2017 13:51:40 GMT+0000 (UTC) -->
<html data-wf-domain="jojos-site.webflow.io" data-wf-page="59241c02679c326a7a8c3f24" data-wf-site="59235a66da66b9016b526a6d">
<head>
    <meta charset="utf-8">
    <title>Contact</title>
    <meta content="Contact" property="og:title">
    <meta content="width=device-width, initial-scale=1" name="viewport">
    <meta content="Webflow" name="generator">
    <link href="https://daks2k3a4ib2z.cloudfront.net/59235a66da66b9016b526a6d/css/jojos-site.webflow.62b2aef1c.css" rel="stylesheet" type="text/css">
    <script src="https://ajax.googleapis.com/ajax/libs/webfont/1.4.7/webfont.js"></script>
    <script type="text/javascript">
WebFont.load({
  google: {
    families: ["Playfair Display:regular,italic,700,700italic,900,900italic","Raleway:100,200,300,regular,500,600,700,800,900"]
  }
});</script>
    <script src="https://daks2k3a4ib2z.cloudfront.net/0globals/modernizr-2.7.1.js" type="text/javascript"></script>
    <link href="https://daks2k3a4ib2z.cloudfront.net/img/favicon.ico" rel="shortcut icon" type="image/x-icon">
    <link href="https://daks2k3a4ib2z.cloudfront.net/img/webclip.png" rel="apple-touch-icon">
</head>
<body class="body">
    <form id="form1" runat="server">
    <div class="main-wrapper"><div class="main navbar w-nav" data-animation="default" data-collapse="none" data-duration="400">
        <div class="homepage-wrapper w-container"><a class="brand w-nav-brand" href="#">
            <img class="homepage-logo main" src="http://uploads.webflow.com/59235a66da66b9016b526a6d/5923f394a6879e6bd117f351_logo.svg"></a>
            <nav class="homepage-links w-nav-menu" role="navigation">
                <a class="homepage-link w-nav-link" href="/showreel.html">Showreel</a>
                <a class="homepage-link w-nav-link" href="/voicereel.html">Voicereel</a>
                <a class="homepage-link w-nav-link" href="/photos.html">Photos</a>
                <a class="homepage-link w-nav-link" href="#">Woofstock!</a>
                <a class="homepage-link w-nav-link" href="/contact.aspx">Contact</a>
            </nav>
            <div class="menu-button w-nav-button">
                <div class="homepage-menu-button-text">
                    <span class="icon-font"></span>Menu
                </div>
            </div>
        </div>
    </div>
    <div class="main-content-container">
        <h1 class="heading">Contact</h1>
        <div class="contact-columns">
        <div class="contact-column">
            <h3>For TV, Film and Theatre and Commercial castings:</h3>
            <p><strong>KERRY FOLEY MANAGEMENT LTD</strong><br>
                        Communications House<br>
                        26 York Street<br>London<br>
                        W1U 6PZ
            </p>
            <p class="contact-details">
                <span class="contact-label">Phone: </span>07747 864001<br>
                <span class="contact-label">E-mail:</span> <a href="#">contact@kfmltd.com</a><br>
                <span class="contact-label">Web:</span>&nbsp;
                <a href="#">kerryfoleymanagement.com</a>
            </p>
        </div>
        <div class="contact-column">
            <!--<h3>For any other enquiries:</h3>-->
            <asp:Literal ID="Literal1" runat="server" Text="<h3>For any other enquiries:</h3>"></asp:Literal>
            <div class="form-block w-form">
                <!--<form data-name="Email Form" id="email-form" name="email-form" action="mailto:bibiplone@hotmail.com" method="post" enctype="text/plain">-->
                    <!--<label for="name">Name:</label>-->
                    <asp:Label ID="Label1" runat="server" Text="Name:" Font-Bold="true"></asp:Label>
                    <!--<input class="field w-input" data-name="Name" id="name" maxlength="256" name="name" placeholder="Enter your name" type="text">-->
                    <asp:TextBox ID="Name" runat="server" CssClass="field w-input" MaxLength="256"></asp:TextBox>
                    <!--<label for="email">Email Address:</label>-->
                    <asp:Label ID="Label2" runat="server" Text="Email Address:" Font-Bold="true"></asp:Label>
                    <!--<input class="field w-input" data-name="Email" id="email" maxlength="256" name="email" placeholder="Enter your email address" required="required" type="email">-->
                    <asp:TextBox id="Email" runat="server" CssClass="field w-input" MaxLength="256"></asp:TextBox>
                    <!--<label for="field">Message:</label>-->
                    <asp:Label ID="Label3" runat="server" Text="Message:" Font-Bold="true"></asp:Label>
                    <!--<textarea class="field multi w-input" id="field" maxlength="5000" name="field" placeholder="Example Text"></textarea>-->
                    <asp:TextBox id="Message" runat="server" TextMode="MultiLine" CssClass="field multi w-input" MaxLength="5000" ></asp:TextBox>
                    <!--<input class="submit w-button" data-wait="Please wait..." type="submit" value="Submit">-->
                    <asp:Button ID="Button1" runat="server" Text="Submit"  CssClass="submit w-button" OnClick="Button1_Click"/>
                <!--</form>-->
                    <div class="w-form-done">
                        <div>Thank you! Your submission has been received!</div>
                    </div>
                        <div class="w-form-fail">
                            <div>Oops! Something went wrong while submitting the form</div>
                        </div>
            </div>
        </div>
    </div>
</div>
    <div class="footer">
        <div>© Joanna Hudson</div>
            <div class="footer-social-links">
                <a class="footer-social-link" href="#"></a>
                <a class="footer-social-link" href="#"></a>
            </div>
        </div>
    </div>
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/2.2.0/jquery.min.js" type="text/javascript"></script>
    <script src="https://daks2k3a4ib2z.cloudfront.net/59235a66da66b9016b526a6d/js/webflow.d6724e82f.js" type="text/javascript"></script>
    <!--[if lte IE 9]><script src="//cdnjs.cloudflare.com/ajax/libs/placeholders/3.0.2/placeholders.min.js"></script><![endif]-->
</body>
</html>


