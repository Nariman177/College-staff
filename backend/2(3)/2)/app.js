vue.component('picture-card',{
  props:['title,' 'picture_url'],
  template: '#template-picture'
});
const vm = new Vue ({
  el: '#main',
  data:{
    pictures:[
      {id:1, title: 'Картинка 1', picture_url:'https://thumbs.dreamstime.com/b/beautiful-rain-forest-ang-ka-nature-trail-doi-inthanon-national-park-thailand-36703721.jpg'}
      {id:2, title: 'Картинка 2', picture_url:'https://thumbs.dreamstime.com/b/beautiful-rain-forest-ang-ka-nature-trail-doi-inthanon-national-park-thailand-36703721.jpg'}
      {id:3, title: 'Картинка 3', picture_url:'https://cdn.pixabay.com/photo/2015/04/23/22/00/tree-736885__480.jpg'}
    ]
  }
})
