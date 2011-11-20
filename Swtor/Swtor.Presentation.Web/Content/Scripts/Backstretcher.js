/* backstretcher v1.0
Stretches a picture to cover the background of a div or BODY.
Copyright (C) 2011 paul pham <http://aquaron.com/jquery/backstretcher>

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
(function ($) { $.fn.backstretcher = function (o) { var _0 = $.extend({ width: '100%', height: '100%', bgs: ['http://farm1.static.flickr.com/181/435733500_49bbe29abb_o.jpg', 'http://farm1.static.flickr.com/181/435734551_4d1aff75e8_o.jpg'] }, o); var __ = { calculate: function (b) { if (b.parent().get(0).tagName === 'BODY') { $('body').css({ overflowY: 'auto' }) } var _3 = b.width(); var _5 = parseInt(_3 / (_0.ow / _0.oh), 10); if (b.parent().get(0).tagName === 'BODY') { if (_5 > $(window).height()) { $('body').css({ overflowY: 'scroll' }); _3 = b.width(); _5 = parseInt(_3 / (_0.ow / _0.oh), 10) } } return [_3, _5] }, loadimage: function (b) { var _2 = b.find('img'); if (_2.length) { _2.hide(); var _1 = __.calculate(b); _2.css({ width: _1[0], height: _1[1] }).fadeIn(); return false } else { _2 = $('<img\/>').attr('src', _0.bgs[_0.index]).hide().appendTo(b) } _2.load(function () { _0.ow = $(this).width(); _0.oh = $(this).height(); var _1 = __.calculate(b); $(this).css({ position: 'absolute', top: 0, left: 0, width: _1[0], height: _1[1] }).fadeIn('slow').parent().css({ height: _1[1] }) }) }, handler: function (b) { var _4 = null; $(window).resize(function () { if (_4) { clearTimeout(_4) } _4 = setTimeout(function () { __.loadimage(b) }, 500) }) } }; return this.each(function () { _0.index = Math.floor(Math.random() * _0.bgs.length); var _6 = $('<div class="aqBackStretcher"><\/div>').css({ width: _0.width, height: _0.height, position: 'relative' }).appendTo(this); $(this).css({ padding: 0, margin: 0 }); __.loadimage(_6); __.handler(_6); return true }) } })(jQuery);