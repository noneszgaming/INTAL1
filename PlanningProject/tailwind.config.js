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
      },
    },
  },
  plugins: [],
}
