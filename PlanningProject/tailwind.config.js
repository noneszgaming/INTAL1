/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Pages/**/*.cshtml',
    './Views/**/*.cshtml'
  ],
  theme: {
    extend: {
      fontFamily: { 
        'titan': ['"Titan One"', 'cursive'],
      },
      colors: {
        'cstm-purple': '#9B00F4',
        'cstm-light-purple': '#E6BCFF',
        'cstm-lobby-limit-purple': '#A664CD',
        'cstm-lobby-date-purple': '#6D4087',
      },
    },
  },
  plugins: [],
}
