from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
def index():
    return render_template('index.html', content = '<img src = "static/img/Planetary.jpg" alt = "">')

@app.route('/shoes')
def shoes():
    return render_template('shoes.html')


if __name__ == "__main__":
    app.run(debug = True)