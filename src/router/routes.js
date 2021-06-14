
const routes = [
  {
    path: '/',
    component: () => import('layouts/MainLayout.vue'),
    children: [{
      path: '',
      component: () => import('pages/Index.vue')
    },
    {
      path: '/map',
      component: () => import('pages/Map.vue')
    },
    {
      path: '/event',
      component: () => import('pages/Event.vue')
    },
    {
      path: '/chat',
      component: () => import('pages/Chat.vue')
    },
    {
      path: '/gallery',
      component: () => import('pages/Gall.vue')
    },
  ],
    meta: {
      layout: 'main'
    }
  },

 
  {
    path: '/auth',
    component: () => import('pages/Auth.vue'),
    meta: {
      layout: 'Auth'
    } },

  // Always leave this as last one,
  // but you can also remove it
  {
    path: '/:catchAll(.*)*',
    component: () => import('pages/Error404.vue')
  }
]

export default routes
