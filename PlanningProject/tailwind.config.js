/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    './Pages/**/*.cshtml',
    './Views/**/*.cshtml'
  ],
  theme: {
    extend: {
      colors: {
        'cstm-purple': '#9B00F4',
      },
    },
  },
  plugins: [],
}
