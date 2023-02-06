$(document).ready(function (){
    //New-Model-Slider
    $('.new-model-slider').slick({
        dots: false,
        infinite: true,
        speed: 700,
        prevArrow: $('.prev-new'),
        nextArrow: $('.next-new'),
        arrows: true,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 5,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    })

    //Slider
    $('.slider').slick({
        dots: true,
        appendDots: $('.slick-slider-dots'),
        arrows:true,
        prevArrow: $('.prev'),
        nextArrow: $('.next'),
        infinite: true,
        speed: 700,
        fade: true,
        cssEase: 'linear',
        autoplay: false,
        autoplaySpeed: 2000,
        slidesToShow: 1,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 1024,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    arrows: false,
                    slidesToShow:1,
                    slidesToScroll: 1
                }
            },
            {
                breakpoint: 480,
                settings: {
                    arrows: false,
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    });
      
    //Counter
    $("[id^=carousel-thumbs]").carousel({
	interval: false
});


/** Fullscreen Buttun **/
$(".carousel-fullscreen").click(function () {
	var id = $(this).attr("href");
	$(id).find(".active").ekkoLightbox({
		type: "image"
	});
});

if ($("[id^=carousel-thumbs] .carousel-item").length < 2) {
	$("#carousel-thumbs [class^=carousel-control-]").remove();
	$("#carousel-thumbs").css("padding", "0 5px");
}

$("#carousel").on("slide.bs.carousel", function (e) {
	var id = parseInt($(e.relatedTarget).attr("data-slide-number"));
	var thumbNum = parseInt(
		$("[id=carousel-selector-" + id + "]")
			.parent()
			.parent()
			.attr("data-slide-number")
	);
	$("[id^=carousel-selector-]").removeClass("selected");
	$("[id=carousel-selector-" + id + "]").addClass("selected");
	$("#carousel-thumbs").carousel(thumbNum);
});

    
})

//Preloader
window.addEventListener('load', function () {
    document.querySelector('body').classList.add("loaded")
});

//Thumbnail
$(function () {
    /*make the master div has a static height to prevent it from disppearing while the master img is feading in,
    this step is important if you use a fadeIn duration for the master img more than 1s, but if you use a duration less than 1s
    you don't need to make the height of the master div is static, and it is preferred to make the duration less than 1s to prevent the
    user to choose 2 images at the same time, so the implementation of the code will be faster than the user selection*/
    $(".master").css({
        height: $(".master img").height() + 13
    });

    //make the width of the thumbnails images is dynamic
    var imagesNumber = $(".thumbnails").children().length,
        marginBetweenImages = 1,
        totalMargins = marginBetweenImages * (imagesNumber - 1),
        imageWidth = (100 - totalMargins) / (imagesNumber);

    $(".thumbnails img").css({
        width: imageWidth + "%",
        marginRight: marginBetweenImages + "%"
    });


    //remove the active class from all thumbnails images and add it to the selected one, then add this selected as the master image in the master div
    $(".thumbnails img").on("click", function () {
        $(this).addClass("active").siblings().removeClass("active");
        $(".master img").hide().attr("src", $(this).attr("src")).fadeIn(300);
    });


    //use the chevron left and right to select images and translate between them
    $(".master .fas").on("click", function () {
        if ($(this).hasClass("fa-chevron-left")) {
            if ($(".thumbnails img.active").is(":first-child")) {
                $(".thumbnails img:last-child").click();
            } else {
                $(".thumbnails img.active").prev().click();
            }
        } else {
            if ($(".thumbnails img.active").is(":last-child")) {
                $(".thumbnails img:first-child").click();
            } else {
                $(".thumbnails img.active").next().click();
            }
        }
    })
})





//Accordion-Menu
var acc = document.getElementsByClassName("accordion-menu");
var i;

for (i = 0; i < acc.length; i++) {
  acc[i].addEventListener("click", function() {
    this.classList.toggle("active-menu");
    var panel = this.nextElementSibling;
    if (panel.style.maxHeight) {
      panel.style.maxHeight = null;
    } else {
      panel.style.maxHeight = panel.scrollHeight + "px";
    } 
  });
}


//Tab
const tabs = document.querySelector(".wrapper");
const tabButton = document.querySelectorAll(".tab-button");
const contents = document.querySelectorAll(".content");

tabs.onclick = e => {
    const id = e.target.dataset.id;
    if (id) {
        tabButton.forEach(btn => {
            btn.classList.remove("active");
        });
        e.target.classList.add("active");

        contents.forEach(content => {
            content.classList.remove("active");
        });
        const element = document.getElementById(id);
        element.classList.add("active");
    }
}


//Tab2
const tabs2 = document.querySelector(".wrapper2");
const tabButton2 = document.querySelectorAll(".tab-button2");
const contents2 = document.querySelectorAll(".content2");

tabs2.onclick = e => {
    const id2 = e.target.dataset.id;
    if (id2) {
        tabButton2.forEach(btn2 => {
            btn2.classList.remove("active2");
        });
        e.target.classList.add("active2");

        contents2.forEach(content2 => {
            content2.classList.remove("active2");
        });
        const element2 = document.getElementById(id2);
        element2.classList.add("active2");
    }
}

//Show password
const togglePassword = document.querySelector("#togglePassword");
const password = document.querySelector("#password");

togglePassword.addEventListener("click", function () {
    // toggle the type attribute
    const type = password.getAttribute("type") === "password" ? "text" : "password";
    password.setAttribute("type", type);

    // toggle the icon
    this.classList.toggle("bi-eye");
});

//Show password2
const togglePassword2 = document.querySelector("#togglePassword2");
const password2 = document.querySelector("#register-password");

togglePassword2.addEventListener("click", function () {
    // toggle the type attribute
    const type = password2.getAttribute("type") === "password" ? "text" : "password";
    password2.setAttribute("type", type);

    // toggle the icon
    this.classList.toggle("bi-eye");
});


//Show password-register
const togglePasswordr = document.querySelector("#togglePasswordr");
const passwordr = document.querySelector("#passwordr");

togglePasswordr.addEventListener("click", function () {
    // toggle the type attribute
    const type = passwordr.getAttribute("type") === "password" ? "text" : "password";
    passwordr.setAttribute("type", type);

    // toggle the icon
    this.classList.toggle("bi-eye");
});

//Show password2
const togglePassword2r = document.querySelector("#togglePassword2r");
const password2r = document.querySelector("#register-passwordr");

togglePassword2r.addEventListener("click", function () {
    // toggle the type attribute
    const type = password2r.getAttribute("type") === "password" ? "text" : "password";
    password2r.setAttribute("type", type);

    // toggle the icon
    this.classList.toggle("bi-eye");
});


//Counter
$('.minus').click(function () {
    var $input = $(this).parent().find('input');
    var count = parseInt($input.val()) - 1;
    count = count < 1 ? 1 : count;
    $input.val(count);
    $input.change();
    return false;
});
$('.plus').click(function () {
    var $input = $(this).parent().find('input');
    $input.val(parseInt($input.val()) + 1);
    $input.change();
    return false;
});

