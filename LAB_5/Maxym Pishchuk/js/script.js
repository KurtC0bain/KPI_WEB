$(function() {
	
	//BEGIN
	$(".accordion__title").on("click", function(e) {

		e.preventDefault();
		var $this = $(this);

		if (!$this.hasClass("accordion-active")) {
			$(".accordion__content").slideUp(400);
			$(".accordion__title").removeClass("accordion-active");
			$('.accordion__arrow').removeClass('accordion__rotate');
		}

		$this.toggleClass("accordion-active");
		$this.next().slideToggle();
		$('.accordion__arrow',this).toggleClass('accordion__rotate');
	});
	//END
	
});
$( "#polzunok" ).slider({
    animate: "slow",
    range: "min",    
    value: 69
});
$("#polzunok").slider({
    animate: "slow",
    range: "min",    
    value: 69,
    slide : function(event, ui) {    
        $("#result-polzunok").text(ui.value);        
    }
});
$( "#result-polzunok" ).text($( "#polzunok" ).slider("value" ));

$( function() {
    $( "#datepicker" ).datepicker();
  } );

$('.prettySocial').prettySocial();

$('#myclock').thooClock({
	onAlarm: function(){},
	offAlarm: function(){},
	onEverySecond: function(){},
  });
  $('#digiclock').jdigiclock({
    imagesPath : 'images/', 
    lang: 'en',
    am_pm : false, 
    weatherLocationCode : '751170', 
    weatherUpdate : 60, 
    svrOffset: 0   
});

$(document).ready(function () {
  $('.jic').inlineCurrency();
  $('.jic-test').inlineCurrency({
      "thousandsSplit": " ",
      "decimalsSplit": ","
  });
});