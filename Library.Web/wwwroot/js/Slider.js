let slideIndex = 0;
showSlides();

function showSlides() {
    const slides = document.querySelectorAll(".slide");
    slides.forEach((slide, index) => {
        slide.style.display = "none";
    });
    slideIndex++;
    if (slideIndex > slides.length) {
        slideIndex = 1;
    }
    slides[slideIndex - 1].style.display = "block";
    setTimeout(showSlides, 8000); // Change image every 8 seconds
}


// ——————————————————————————————————————————————————
// TextScramble
// ——————————————————————————————————————————————————

class TextScramble {
  constructor(el) {
    this.el = el;
    this.chars = '!<>-_\\/[]{}—=+*^?#________';
    this.update = this.update.bind(this);
  }
  setText(newText) {
    const oldText = this.el.innerText;
    const length = Math.max(oldText.length, newText.length);
    const promise = new Promise(resolve => this.resolve = resolve);
    this.queue = [];
    for (let i = 0; i < length; i++) {
      const from = oldText[i] || '';
      const to = newText[i] || '';
      const start = Math.floor(Math.random() * 40);
      const end = start + Math.floor(Math.random() * 40);
      this.queue.push({ from, to, start, end });
    }
    cancelAnimationFrame(this.frameRequest);
    this.frame = 0;
    this.update();
    return promise;
  }
  update() {
    let output = '';
    let complete = 0;
    for (let i = 0, n = this.queue.length; i < n; i++) {
      let { from, to, start, end, char } = this.queue[i];
      if (this.frame >= end) {
        complete++;
        output += to;
      } else if (this.frame >= start) {
        if (!char || Math.random() < 0.28) {
          char = this.randomChar();
          this.queue[i].char = char;
        }
        output += `<span class="dud">${char}</span>`;
      } else {
        output += from;
      }
    }
    this.el.innerHTML = output;
    if (complete === this.queue.length) {
      this.resolve();
    } else {
      this.frameRequest = requestAnimationFrame(this.update);
      this.frame++;
    }
  }
  randomChar() {
    return this.chars[Math.floor(Math.random() * this.chars.length)];
  }}


// ——————————————————————————————————————————————————
// Example
// ——————————————————————————————————————————————————

const phrases = [
'"Dusunmek tehlikelidir, cunku dusunmeye baslayinca durmak zordur." - Voltaire',
'"Hayat bir yolculuktur ve varilacak bir hedef degil." - Ralph Waldo Emerson',
'"Basarisizlik, ertesi gun daha akillica yeniden baslama firsatidir." - Thomas J. Watson',
'"Sanat, gercegin pesinde kosmaktir." - Pablo Picasso',
'"Tarih, tekerrur eden bir farsa donusmedikce trajedi degildir." - Karl Marx',
'"Liderlik, vizyona sahip olmak ve insanlari bu vizyonu gerceklestirmeye motive etmektir." - John Maxwell',
'"Ask, ruhun eksik olan yarisini bulma arzusudur." - Platon',
'"Kuskuculuk, bilgeligin baslangicidir." - Descartes',
'"Dusunmek, varolusun anlamini aramaktir." - Heidegger'];


const el = document.querySelector('.text');
const fx = new TextScramble(el);

let counter = 0;
const next = () => {
  fx.setText(phrases[counter]).then(() => {
    setTimeout(next, 5000);
  });
  counter = (counter + 1) % phrases.length;
};

next();



$(function () {

    // Cache some selectors

    var clock = $('#clock'),
        alarm = clock.find('.alarm'),
        ampm = clock.find('.ampm');

    // Map digits to their names (this will be an array)
    var digit_to_name = 'zero one two three four five six seven eight nine'.split(' ');

    // This object will hold the digit elements
    var digits = {};

    // Positions for the hours, minutes, and seconds
    var positions = [
        'h1', 'h2', ':', 'm1', 'm2', ':', 's1', 's2'
    ];

    // Generate the digits with the needed markup,
    // and add them to the clock

    var digit_holder = clock.find('.digits');

    $.each(positions, function () {

        if (this == ':') {
            digit_holder.append('<div class="dots">');
        }
        else {

            var pos = $('<div>');

            for (var i = 1; i < 8; i++) {
                pos.append('<span class="d' + i + '">');
            }

            // Set the digits as key:value pairs in the digits object
            digits[this] = pos;

            // Add the digit elements to the page
            digit_holder.append(pos);
        }

    });

    // Add the weekday names

    var weekday_names = 'PZT SAL CAR PER CUM CMT PAZ'.split(' '),
        weekday_holder = clock.find('.weekdays');

    $.each(weekday_names, function () {
        weekday_holder.append('<span>' + this + '</span>');
    });

    var weekdays = clock.find('.weekdays span');

    // Run a timer every second and update the clock

    (function update_time() {

        // Use moment.js to output the current time as a string
        // hh is for the hours in 12-hour format,
        // mm - minutes, ss-seconds (all with leading zeroes),
        // d is for day of week and A is for AM/PM

        var now = moment().format("hhmmssdA");

        digits.h1.attr('class', digit_to_name[now[0]]);
        digits.h2.attr('class', digit_to_name[now[1]]);
        digits.m1.attr('class', digit_to_name[now[2]]);
        digits.m2.attr('class', digit_to_name[now[3]]);
        digits.s1.attr('class', digit_to_name[now[4]]);
        digits.s2.attr('class', digit_to_name[now[5]]);

        // The library returns Sunday as the first day of the week.
        // Stupid, I know. Lets shift all the days one position down, 
        // and make Sunday last

        var dow = now[6];
        dow--;

        // Sunday!
        if (dow < 0) {
            // Make it last
            dow = 6;
        }

        // Mark the active day of the week
        weekdays.removeClass('active').eq(dow).addClass('active');

        // Set the am/pm text:
        ampm.text(now[7] + now[8]);

        // Schedule this function to be run again in 1 sec
        setTimeout(update_time, 1000);

    })();

});