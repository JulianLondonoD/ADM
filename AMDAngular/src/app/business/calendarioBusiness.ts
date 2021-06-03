import { Moment } from "moment";

export const buildCalendar = (fecha : Moment) : Moment[][] => {
    const a :Moment[][] = [];

    const startDay = fecha.clone().startOf("month").startOf("week");
    const endDay = fecha.clone().endOf("month").endOf("week");

    const _date = startDay.clone().subtract(1, "day");

    while (_date.isBefore(endDay, "day")) {
      a.push(
        Array(7)
          .fill(0)
          .map(() => _date.add(1, "day").clone())
      );
    }
    return a;
  }