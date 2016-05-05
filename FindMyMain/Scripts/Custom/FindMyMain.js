function processAnswer(answerData) {

    var championId = '#champion' + answerData.ChampionId

    // $(championId).fadeOut()

    $(championId).showBaloon();

    // alert(answerData.Answer)
}

// baloon

$(function () {

    $("#grid > figure").showBalloon({
        position: "left",
        offsetX: 50,
        offsetY: 50,
        tipSize: 20,
        css: {
            maxWidth: "17em",
            border: "solid 5px #463974",
            color: "#463974",
            fontWeight: "bold",
            fontSize: "130%",
            backgroundColor: "#efefef"
        }
    });
});


// quick search regex
var qsRegex;

// init Isotope
var $grid = $('#fmm-grid').isotope({
    itemSelector: '.championItem',
    layoutMode: 'fitRows',
    filter: function () {
        return qsRegex ? $(this).text().match(qsRegex) : true;
    }
});

// use value of search field to filter
var $quicksearch = $('#fmm-filter').keyup(debounce(function () {
    qsRegex = new RegExp($quicksearch.val(), 'gi');
    $grid.isotope();
}, 200));

// debounce so filtering doesn't happen every millisecond
function debounce(fn, threshold) {
    var timeout;
    return function debounced() {
        if (timeout) {
            clearTimeout(timeout);
        }
        function delayed() {
            fn();
            timeout = null;
        }
        timeout = setTimeout(delayed, threshold || 100);
    }
}