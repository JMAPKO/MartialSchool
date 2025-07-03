

import 'package:flutter/material.dart';
import 'package:pakua_yb/screen/home_page.dart';

Map<String, WidgetBuilder> GetRoute() {
  return {
    "/": (_) => HomePage(),
  };
}